/*
order: 20
title: MEAI Tools
slug: meai-tools

Example showing how to use the Vellum client as MEAI AIFunction tools.
*/

using Microsoft.Extensions.AI;

namespace Vellum.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_MeaiTools()
    {
        //// Create a Vellum client and wrap it as MEAI AIFunction tools.
        using var client = GetAuthenticatedClient();

        //// Create tools for use with any IChatClient.
        var executePromptTool = client.AsExecutePromptTool();
        var searchDocumentsTool = client.AsSearchDocumentsTool();
        var listDeploymentsTool = client.AsListDeploymentsTool();
        var listDocumentIndexesTool = client.AsListDocumentIndexesTool();

        //// Verify the tools were created successfully.
        executePromptTool.Should().NotBeNull();
        executePromptTool.Name.Should().Be("vellum_execute_prompt");

        searchDocumentsTool.Should().NotBeNull();
        searchDocumentsTool.Name.Should().Be("vellum_search_documents");

        listDeploymentsTool.Should().NotBeNull();
        listDeploymentsTool.Name.Should().Be("vellum_list_deployments");

        listDocumentIndexesTool.Should().NotBeNull();
        listDocumentIndexesTool.Name.Should().Be("vellum_list_document_indexes");
    }
}
