# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Vellum SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Vellum's prompt execution, document search, deployment management, and document index browsing.

## Installation

```bash
dotnet add package Vellum
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsExecutePromptTool()` | `vellum_execute_prompt` | Execute a deployed Vellum prompt with input variables |
| `AsSearchDocumentsTool()` | `vellum_search_documents` | Search documents in a Vellum document index |
| `AsListDeploymentsTool()` | `vellum_list_deployments` | List all prompt deployments with status and labels |
| `AsListDocumentIndexesTool()` | `vellum_list_document_indexes` | List all document indexes in the workspace |

## Usage

```csharp
using Vellum;
using Microsoft.Extensions.AI;

var vellumClient = new VellumClient(
    apiKey: Environment.GetEnvironmentVariable("VELLUM_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        vellumClient.AsExecutePromptTool(),
        vellumClient.AsSearchDocumentsTool(),
        vellumClient.AsListDeploymentsTool(),
        vellumClient.AsListDocumentIndexesTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "List all prompt deployments and search the knowledge base for information about onboarding."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
