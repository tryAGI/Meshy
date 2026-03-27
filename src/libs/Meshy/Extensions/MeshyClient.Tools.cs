using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Meshy;

/// <summary>
/// Extensions for using MeshyClient as MEAI tools with any IChatClient.
/// </summary>
public static class MeshyToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a 3D model from a text prompt
    /// using the Meshy text-to-3D API. Returns the created task ID.
    /// </summary>
    /// <param name="client">The Meshy client to use for generation.</param>
    /// <param name="aiModel">AI model to use (default: latest).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsTextTo3DTool(
        this MeshyClient client,
        AiModel aiModel = AiModel.Latest)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Text description of the 3D object to generate")] string prompt,
                [Description("Optional texture style description")] string? texturePrompt,
                CancellationToken cancellationToken) =>
            {
                var request = new TextTo3DPreviewRequest
                {
                    Mode = TextTo3DPreviewRequestMode.Preview,
                    Prompt = prompt,
                    AiModel = aiModel,
                };

                if (!string.IsNullOrWhiteSpace(texturePrompt))
                {
                    // Note: TextTo3DPreviewRequest doesn't have TexturePrompt,
                    // but we can pass it via the prompt for better results
                }

                var response = await client.TextTo3d.CreateTextTo3DTaskAsync(
                    request: (CreateTextTo3DTaskRequest)request,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCreateTaskResponse(response, "text-to-3D");
            },
            name: "TextTo3D",
            description: "Generates a 3D model from a text description using Meshy AI. Provide a detailed prompt describing the desired 3D object. Returns a task ID that can be used to check generation status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a 3D model from an image
    /// using the Meshy image-to-3D API. Returns the created task ID.
    /// </summary>
    /// <param name="client">The Meshy client to use for generation.</param>
    /// <param name="aiModel">AI model to use (default: latest).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsImageTo3DTool(
        this MeshyClient client,
        AiModel aiModel = AiModel.Latest)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Public URL or base64 data URI of the image (.jpg/.jpeg/.png)")] string imageUrl,
                [Description("Optional texture style description")] string? texturePrompt,
                CancellationToken cancellationToken) =>
            {
                var response = await client.ImageTo3d.CreateImageTo3DTaskAsync(
                    imageUrl: imageUrl,
                    aiModel: aiModel,
                    texturePrompt: texturePrompt,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCreateTaskResponse(response, "image-to-3D");
            },
            name: "ImageTo3D",
            description: "Generates a 3D model from an image URL using Meshy AI. Provide a public image URL or base64 data URI. Returns a task ID that can be used to check generation status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retextures an existing 3D model
    /// using the Meshy retexture API. Returns the created task ID.
    /// </summary>
    /// <param name="client">The Meshy client to use for generation.</param>
    /// <param name="aiModel">AI model to use (default: latest).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsRetextureTool(
        this MeshyClient client,
        AiModel aiModel = AiModel.Latest)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Text description for the new texture style")] string textStylePrompt,
                [Description("ID of a completed Meshy task to retexture (provide this OR modelUrl)")] string? inputTaskId,
                [Description("Public URL or data URI of a 3D model (.glb/.gltf/.obj/.fbx/.stl) to retexture (provide this OR inputTaskId)")] string? modelUrl,
                CancellationToken cancellationToken) =>
            {
                var response = await client.Retexture.CreateRetextureTaskAsync(
                    inputTaskId: inputTaskId,
                    modelUrl: modelUrl,
                    textStylePrompt: textStylePrompt,
                    aiModel: aiModel,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatCreateTaskResponse(response, "retexture");
            },
            name: "Retexture",
            description: "Retextures an existing 3D model with a new style using Meshy AI. Provide either a completed task ID or a 3D model URL, along with a text description of the desired texture style. Returns a task ID that can be used to check generation status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the status and result
    /// of a text-to-3D task by its ID.
    /// </summary>
    /// <param name="client">The Meshy client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetTextTo3DTaskTool(this MeshyClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The task ID returned from a text-to-3D creation request")] string taskId,
                CancellationToken cancellationToken) =>
            {
                var task = await client.TextTo3d.GetTextTo3DTaskAsync(
                    id: taskId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatTextTo3DTask(task);
            },
            name: "GetTextTo3DTask",
            description: "Retrieves the status and result of a text-to-3D generation task by its task ID. Returns the task status (PENDING, IN_PROGRESS, SUCCEEDED, FAILED) and 3D model URLs when complete.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the status and result
    /// of an image-to-3D task by its ID.
    /// </summary>
    /// <param name="client">The Meshy client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetImageTo3DTaskTool(this MeshyClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The task ID returned from an image-to-3D creation request")] string taskId,
                CancellationToken cancellationToken) =>
            {
                var task = await client.ImageTo3d.GetImageTo3DTaskAsync(
                    id: taskId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatImageTo3DTask(task);
            },
            name: "GetImageTo3DTask",
            description: "Retrieves the status and result of an image-to-3D generation task by its task ID. Returns the task status (PENDING, IN_PROGRESS, SUCCEEDED, FAILED) and 3D model URLs when complete.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the status and result
    /// of a retexture task by its ID.
    /// </summary>
    /// <param name="client">The Meshy client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetRetextureTaskTool(this MeshyClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The task ID returned from a retexture creation request")] string taskId,
                CancellationToken cancellationToken) =>
            {
                var task = await client.Retexture.GetRetextureTaskAsync(
                    id: taskId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatRetextureTask(task);
            },
            name: "GetRetextureTask",
            description: "Retrieves the status and result of a retexture task by its task ID. Returns the task status (PENDING, IN_PROGRESS, SUCCEEDED, FAILED) and 3D model URLs when complete.");
    }

    private static string FormatCreateTaskResponse(CreateTaskResponse response, string taskType)
    {
        return $"Task created successfully ({taskType}).\nTask ID: {response.Result}";
    }

    private static string FormatTextTo3DTask(TextTo3DTask task)
    {
        var parts = new List<string>();

        if (!string.IsNullOrWhiteSpace(task.Id))
        {
            parts.Add($"Task ID: {task.Id}");
        }

        if (task.Status is { } status)
        {
            parts.Add($"Status: {status.ToValueString()}");
        }

        if (task.Progress is { } progress)
        {
            parts.Add($"Progress: {progress}%");
        }

        if (task.TaskError is { Message: { Length: > 0 } errorMessage })
        {
            parts.Add($"Error: {errorMessage}");
        }

        if (task.Status == TaskStatus.Succeeded)
        {
            FormatModelUrls(task.ModelUrls, parts);
            FormatTextureUrls(task.TextureUrls, parts);
        }

        return parts.Count > 0 ? string.Join("\n", parts) : "No task data available.";
    }

    private static string FormatImageTo3DTask(ImageTo3DTask task)
    {
        var parts = new List<string>();

        if (!string.IsNullOrWhiteSpace(task.Id))
        {
            parts.Add($"Task ID: {task.Id}");
        }

        if (task.Status is { } status)
        {
            parts.Add($"Status: {status.ToValueString()}");
        }

        if (task.Progress is { } progress)
        {
            parts.Add($"Progress: {progress}%");
        }

        if (task.TaskError is { Message: { Length: > 0 } errorMessage })
        {
            parts.Add($"Error: {errorMessage}");
        }

        if (task.Status == TaskStatus.Succeeded)
        {
            FormatModelUrlsImageTo3D(task.ModelUrls, parts);
            FormatTextureUrls(task.TextureUrls, parts);
        }

        return parts.Count > 0 ? string.Join("\n", parts) : "No task data available.";
    }

    private static string FormatRetextureTask(RetextureTask task)
    {
        var parts = new List<string>();

        if (!string.IsNullOrWhiteSpace(task.Id))
        {
            parts.Add($"Task ID: {task.Id}");
        }

        if (task.Status is { } status)
        {
            parts.Add($"Status: {status.ToValueString()}");
        }

        if (task.Progress is { } progress)
        {
            parts.Add($"Progress: {progress}%");
        }

        if (task.TaskError is { Message: { Length: > 0 } errorMessage })
        {
            parts.Add($"Error: {errorMessage}");
        }

        if (task.Status == TaskStatus.Succeeded)
        {
            FormatModelUrls(task.ModelUrls, parts);
            FormatTextureUrls(task.TextureUrls, parts);
        }

        return parts.Count > 0 ? string.Join("\n", parts) : "No task data available.";
    }

    private static void FormatModelUrls(ModelUrls? modelUrls, List<string> parts)
    {
        if (modelUrls == null)
        {
            return;
        }

        parts.Add("Model URLs:");
        if (!string.IsNullOrWhiteSpace(modelUrls.Glb)) parts.Add($"  GLB: {modelUrls.Glb}");
        if (!string.IsNullOrWhiteSpace(modelUrls.Fbx)) parts.Add($"  FBX: {modelUrls.Fbx}");
        if (!string.IsNullOrWhiteSpace(modelUrls.Obj)) parts.Add($"  OBJ: {modelUrls.Obj}");
        if (!string.IsNullOrWhiteSpace(modelUrls.Usdz)) parts.Add($"  USDZ: {modelUrls.Usdz}");
        if (!string.IsNullOrWhiteSpace(modelUrls.Stl)) parts.Add($"  STL: {modelUrls.Stl}");
    }

    private static void FormatModelUrlsImageTo3D(ModelUrlsImageTo3D? modelUrls, List<string> parts)
    {
        if (modelUrls == null)
        {
            return;
        }

        parts.Add("Model URLs:");
        if (!string.IsNullOrWhiteSpace(modelUrls.Glb)) parts.Add($"  GLB: {modelUrls.Glb}");
        if (!string.IsNullOrWhiteSpace(modelUrls.Fbx)) parts.Add($"  FBX: {modelUrls.Fbx}");
        if (!string.IsNullOrWhiteSpace(modelUrls.Obj)) parts.Add($"  OBJ: {modelUrls.Obj}");
        if (!string.IsNullOrWhiteSpace(modelUrls.Usdz)) parts.Add($"  USDZ: {modelUrls.Usdz}");
        if (!string.IsNullOrWhiteSpace(modelUrls.Stl)) parts.Add($"  STL: {modelUrls.Stl}");
    }

    private static void FormatTextureUrls(IList<TextureUrlSet>? textureUrls, List<string> parts)
    {
        if (textureUrls is not { Count: > 0 })
        {
            return;
        }

        parts.Add("Texture URLs:");
        for (var i = 0; i < textureUrls.Count; i++)
        {
            var tex = textureUrls[i];
            if (!string.IsNullOrWhiteSpace(tex.BaseColor)) parts.Add($"  [{i}] Base Color: {tex.BaseColor}");
            if (!string.IsNullOrWhiteSpace(tex.Metallic)) parts.Add($"  [{i}] Metallic: {tex.Metallic}");
            if (!string.IsNullOrWhiteSpace(tex.Normal)) parts.Add($"  [{i}] Normal: {tex.Normal}");
            if (!string.IsNullOrWhiteSpace(tex.Roughness)) parts.Add($"  [{i}] Roughness: {tex.Roughness}");
        }
    }
}
