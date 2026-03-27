# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Meshy SDK provides `AIFunction` tool wrappers from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai), allowing you to use Meshy 3D generation as tools with any `IChatClient`.

## Installation

```bash
dotnet add package Meshy
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsTextTo3DTool()` | `TextTo3D` | Generates a 3D model from a text prompt. Returns a task ID for status polling. |
| `AsImageTo3DTool()` | `ImageTo3D` | Generates a 3D model from an image URL. Returns a task ID for status polling. |
| `AsRetextureTool()` | `Retexture` | Retextures an existing 3D model with a new style. Returns a task ID. |
| `AsGetTextTo3DTaskTool()` | `GetTextTo3DTask` | Retrieves status and result of a text-to-3D task by ID. |
| `AsGetImageTo3DTaskTool()` | `GetImageTo3DTask` | Retrieves status and result of an image-to-3D task by ID. |
| `AsGetRetextureTaskTool()` | `GetRetextureTask` | Retrieves status and result of a retexture task by ID. |

## Text-to-3D Tool

Use `AsTextTo3DTool()` to create an `AIFunction` that generates 3D models from text descriptions:

```csharp
using Meshy;
using Microsoft.Extensions.AI;

var meshyClient = new MeshyClient(apiKey: Environment.GetEnvironmentVariable("MESHY_API_KEY")!);

var textTo3DTool = meshyClient.AsTextTo3DTool(
    aiModel: AiModel.Latest);

// Use with any IChatClient
IChatClient chatClient = /* your chat client */;
var options = new ChatOptions
{
    Tools = [textTo3DTool],
};

var response = await chatClient.GetResponseAsync(
    "Create a 3D model of a wooden chair with carved legs",
    options);
```

## Image-to-3D Tool

Use `AsImageTo3DTool()` to create a 3D model from an image:

```csharp
var imageTo3DTool = meshyClient.AsImageTo3DTool(
    aiModel: AiModel.Latest);

var options = new ChatOptions
{
    Tools = [imageTo3DTool],
};
```

## Retexture Tool

Use `AsRetextureTool()` to retexture an existing 3D model:

```csharp
var retextureTool = meshyClient.AsRetextureTool(
    aiModel: AiModel.Latest);

var options = new ChatOptions
{
    Tools = [retextureTool],
};
```

## Task Status Tools

Meshy uses an async task pattern -- creation endpoints return a task ID, and you poll for results. The `AsGet*TaskTool()` methods let the AI agent check task status:

```csharp
var options = new ChatOptions
{
    Tools =
    [
        meshyClient.AsTextTo3DTool(),
        meshyClient.AsGetTextTo3DTaskTool(),
    ],
};
```

## Combining All Tools

All tools can be used together to give the AI agent full 3D generation and status-checking capabilities:

```csharp
var options = new ChatOptions
{
    Tools =
    [
        meshyClient.AsTextTo3DTool(),
        meshyClient.AsImageTo3DTool(),
        meshyClient.AsRetextureTool(),
        meshyClient.AsGetTextTo3DTaskTool(),
        meshyClient.AsGetImageTo3DTaskTool(),
        meshyClient.AsGetRetextureTaskTool(),
    ],
};
```

## Async Task Pattern

Meshy generation tasks are asynchronous. The creation tools (`AsTextTo3DTool`, `AsImageTo3DTool`, `AsRetextureTool`) return a task ID. The status tools (`AsGetTextTo3DTaskTool`, `AsGetImageTo3DTaskTool`, `AsGetRetextureTaskTool`) can then be used to poll for completion. Task statuses are:

- `PENDING` -- Task is queued
- `IN_PROGRESS` -- Generation is in progress
- `SUCCEEDED` -- Generation complete, 3D model URLs available
- `FAILED` -- Generation failed
- `CANCELED` -- Task was canceled
