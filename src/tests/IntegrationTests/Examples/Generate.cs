/*
order: 10
title: Text to 3D
slug: text-to-3d

Shows how to create a text-to-3D preview task and poll for completion.
*/

namespace Meshy.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TextTo3D()
    {
        using var client = GetAuthenticatedClient();

        //// Create a text-to-3D preview task using an implicit conversion.
        var response = await client.TextTo3d.CreateTextTo3DTaskAsync(
            new TextTo3DPreviewRequest
            {
                Mode = TextTo3DPreviewRequestMode.Preview,
                Prompt = "a wooden treasure chest",
                AiModel = AiModel.Latest,
            });
        response.Result.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Task ID: {response.Result}");

        //// Poll the task until it completes.
        var task = await client.TextTo3d.GetTextTo3DTaskAsync(response.Result!);
        task.Id.Should().NotBeNullOrEmpty();
        task.Status.Should().NotBeNull();
        Console.WriteLine($"Status: {task.Status}, Progress: {task.Progress}%");
    }
}
