namespace Meshy.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static MeshyClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MESHY_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("MESHY_API_KEY environment variable is not found.");

        var client = new MeshyClient(apiKey);
        
        return client;
    }
}
