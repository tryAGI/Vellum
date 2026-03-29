using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Vellum;

/// <summary>
/// Extensions for using VellumClient as MEAI tools with any IChatClient.
/// </summary>
public static class VellumToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that executes a deployed Vellum prompt,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Vellum client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsExecutePromptTool(
        this VellumClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                string promptDeploymentName,
                string inputsJson,
                CancellationToken cancellationToken) =>
            {
                var inputs = new List<PromptDeploymentInputRequest>();

                try
                {
                    using var doc = JsonDocument.Parse(inputsJson);
                    foreach (var prop in doc.RootElement.EnumerateObject())
                    {
                        PromptDeploymentInputRequest input = new StringInputRequest
                        {
                            Name = prop.Name,
                            Value = prop.Value.GetString() ?? prop.Value.GetRawText(),
                        };
                        inputs.Add(input);
                    }
                }
                catch (JsonException)
                {
                    // If not valid JSON object, treat entire string as single "input" variable
                    PromptDeploymentInputRequest input = new StringInputRequest
                    {
                        Name = "input",
                        Value = inputsJson,
                    };
                    inputs.Add(input);
                }

                var response = await client.ExecutePromptAsync(
                    inputs: inputs,
                    promptDeploymentName: promptDeploymentName,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "vellum_execute_prompt",
            description: "Execute a deployed Vellum prompt. Provide the prompt deployment name and a JSON object of input variable name/value pairs.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that searches documents in a Vellum document index,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Vellum client to use.</param>
    /// <param name="documentIndexName">Optional default document index name to search against.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsSearchDocumentsTool(
        this VellumClient client,
        string? documentIndexName = null)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                string query,
                string? indexName,
                CancellationToken cancellationToken) =>
            {
                var effectiveIndexName = indexName ?? documentIndexName;

                var response = await client.SearchAsync(
                    query: query,
                    indexName: null,
                    documentIndex: effectiveIndexName,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var results = new List<object>();
                foreach (var result in response.Results)
                {
                    results.Add(new
                    {
                        result.Text,
                        result.Score,
                        result.Keywords,
                    });
                }

                return results;
            },
            name: "vellum_search_documents",
            description: "Search documents in a Vellum document index. Provide a search query and optionally a document index name.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all prompt deployments,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Vellum client to use.</param>
    /// <param name="limit">Maximum number of deployments to return (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListDeploymentsTool(
        this VellumClient client,
        int limit = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.SubpackageDeployments.ListAsync(
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var results = new List<object>();
                if (response.Results is not null)
                {
                    foreach (var deployment in response.Results)
                    {
                        results.Add(new
                        {
                            deployment.Id,
                            deployment.Name,
                            deployment.Label,
                            Status = deployment.Status?.ToString(),
                            deployment.Description,
                            deployment.LastDeployedOn,
                        });
                    }
                }

                return results;
            },
            name: "vellum_list_deployments",
            description: "List all prompt deployments in the Vellum workspace, including their names, labels, and status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all document indexes,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Vellum client to use.</param>
    /// <param name="limit">Maximum number of document indexes to return (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListDocumentIndexesTool(
        this VellumClient client,
        int limit = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.SubpackageDocumentIndexes.ListAsync(
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var results = new List<object>();
                if (response.Results is not null)
                {
                    foreach (var index in response.Results)
                    {
                        results.Add(new
                        {
                            index.Id,
                            index.Name,
                            index.Label,
                            Status = index.Status?.ToString(),
                            index.Created,
                        });
                    }
                }

                return results;
            },
            name: "vellum_list_document_indexes",
            description: "List all document indexes in the Vellum workspace, including their names, labels, and status.");
    }
}
