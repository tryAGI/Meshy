/*
order: 40
title: MEAI Tools
slug: meai-tools

Shows how to use Meshy AIFunction tools with any IChatClient.
*/

namespace Meshy.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void AsTextTo3DTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a text-to-3D tool from the Meshy client for use with any IChatClient.
        var tool = client.AsTextTo3DTool(
            aiModel: AiModel.Latest);
        tool.Name.Should().Be("TextTo3D");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsImageTo3DTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create an image-to-3D tool for generating 3D models from images.
        var tool = client.AsImageTo3DTool(
            aiModel: AiModel.Latest);
        tool.Name.Should().Be("ImageTo3D");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsRetextureTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a retexture tool for applying new textures to existing 3D models.
        var tool = client.AsRetextureTool(
            aiModel: AiModel.Latest);
        tool.Name.Should().Be("Retexture");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetTextTo3DTaskTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a task status tool for checking text-to-3D generation progress.
        var tool = client.AsGetTextTo3DTaskTool();
        tool.Name.Should().Be("GetTextTo3DTask");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetImageTo3DTaskTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a task status tool for checking image-to-3D generation progress.
        var tool = client.AsGetImageTo3DTaskTool();
        tool.Name.Should().Be("GetImageTo3DTask");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void AsGetRetextureTaskTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a task status tool for checking retexture progress.
        var tool = client.AsGetRetextureTaskTool();
        tool.Name.Should().Be("GetRetextureTask");
        tool.Description.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public void CombineAllTools()
    {
        using var client = GetAuthenticatedClient();

        //// Combine all tools for full 3D generation and status-checking capabilities.
        var tools = new[]
        {
            client.AsTextTo3DTool(),
            client.AsImageTo3DTool(),
            client.AsRetextureTool(),
            client.AsGetTextTo3DTaskTool(),
            client.AsGetImageTo3DTaskTool(),
            client.AsGetRetextureTaskTool(),
        };

        tools.Should().HaveCount(6);
        tools.Select(t => t.Name).Should().OnlyHaveUniqueItems();
    }
}
