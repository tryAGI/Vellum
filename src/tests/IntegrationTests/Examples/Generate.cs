/*
order: 10
title: Getting Started
slug: getting-started

Basic example showing how to create a client and list prompt deployments.
*/

namespace Vellum.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GetStarted()
    {
        //// Create a Vellum client using your API key.
        using var client = GetAuthenticatedClient();

        //// List all prompt deployments in your workspace.
        var deployments = await client.SubpackageDeployments.ListAsync(
            limit: 10);

        deployments.Should().NotBeNull();
    }
}
