namespace Vellum.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static VellumClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("VELLUM_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("VELLUM_API_KEY environment variable is not found.");

        var client = new VellumClient(apiKey);
        
        return client;
    }
}
