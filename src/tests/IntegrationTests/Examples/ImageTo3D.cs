/*
order: 20
title: Image to 3D
slug: image-to-3d

Shows how to create an image-to-3D task from a URL.
*/

namespace Meshy.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ImageTo3D()
    {
        using var client = GetAuthenticatedClient();

        //// Create an image-to-3D task from an image URL.
        var response = await client.ImageTo3d.CreateImageTo3DTaskAsync(new ImageTo3DRequest
        {
            ImageUrl = "https://example.com/chair.png",
            AiModel = AiModel.Latest,
        });
        response.Result.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Task ID: {response.Result}");

        //// Retrieve the task status.
        var task = await client.ImageTo3d.GetImageTo3DTaskAsync(response.Result!);
        task.Id.Should().NotBeNullOrEmpty();
        Console.WriteLine($"Status: {task.Status}, Progress: {task.Progress}%");
    }
}
