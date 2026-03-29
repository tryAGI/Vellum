# CLAUDE.md -- Vellum SDK

## Overview

Auto-generated C# SDK for [Vellum AI](https://www.vellum.ai/) -- prompt engineering, evaluation, deployment, observability, and workflow orchestration for AI product development.
OpenAPI spec from `https://docs.vellum.ai/openapi.json` (3.1.0).

## Build & Test

```bash
dotnet build Vellum.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth (sent as `X-API-KEY` header via PrepareRequest hook):

```csharp
var client = new VellumClient(apiKey); // VELLUM_API_KEY env var
```

## Key Files

- `src/libs/Vellum/openapi.yaml` -- OpenAPI spec (downloaded from docs.vellum.ai)
- `src/libs/Vellum/generate.sh` -- Downloads spec, fixes auth, strips X-API-KEY params, runs autosdk
- `src/libs/Vellum/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Vellum/Extensions/VellumClient.Auth.cs` -- PrepareRequest hook: `Bearer` -> `X-API-KEY`
- `src/libs/Vellum/Extensions/VellumClient.AsTool.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with API key auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

The `generate.sh` applies fixes via `jq` and `--security-scheme`:

**CLI flags:**
- `--security-scheme Http:Header:Bearer` -- Overrides spec's `apiKey` auth with standard HTTP bearer

**Pre-generation (`jq`):**
1. Converts `apiKey` security scheme to `http/bearer`
2. Adds top-level `security` array
3. Sets single server URL to `https://api.vellum.ai` (spec has 3 servers)
4. Strips per-operation `X-API-KEY` and `X-API-Version` header parameters (auth handled via security scheme)

## Auth Hook

Vellum uses `X-API-KEY: <key>` header (not `Authorization: Bearer`). The `PrepareRequest` hook in `Extensions/VellumClient.Auth.cs` rewrites the header:

```csharp
partial void PrepareRequest(HttpClient client, HttpRequestMessage request)
{
    if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { } apiKey })
    {
        request.Headers.Authorization = null;
        request.Headers.TryAddWithoutValidation("X-API-KEY", apiKey);
    }
}
```

## Sub-client Pattern

Vellum API has tagged operations generating sub-clients:
- `client.ExecutePromptAsync(...)` -- Execute a deployed prompt
- `client.SearchAsync(...)` -- Search documents in an index
- `client.ExecuteWorkflowAsync(...)` -- Execute a deployed workflow
- `client.SubpackageDeployments.ListAsync(...)` -- List prompt deployments
- `client.SubpackageDocumentIndexes.ListAsync(...)` -- List document indexes
- `client.SubpackageDocuments.ListAsync(...)` -- List documents
- `client.SubpackageTestSuiteRuns.CreateAsync(...)` -- Create test suite run
- `client.SubpackageWorkflowDeployments.ListAsync(...)` -- List workflow deployments

## MEAI Tools

The SDK provides `AIFunction` tool wrappers for use with any `IChatClient`:
- `AsExecutePromptTool()` -- Execute a deployed Vellum prompt
- `AsSearchDocumentsTool()` -- Search documents in a document index
- `AsListDeploymentsTool()` -- List prompt deployments
- `AsListDocumentIndexesTool()` -- List document indexes

## Endpoints Summary

| Category | Endpoints | Description |
|----------|-----------|-------------|
| Execute Prompt | 2 (sync + stream) | Execute deployed prompts |
| Execute Workflow | 3 (sync + async + stream) | Execute deployed workflows |
| Search | 1 | Search document indexes |
| Deployments | 7 | List, retrieve, releases, tags |
| Workflow Deployments | 10 | List, retrieve, releases, tags, execution events |
| Documents | 5 | List, retrieve, update, delete, upload |
| Document Indexes | 8 | CRUD + add/remove documents |
| Test Suites | 4 | Test cases CRUD + bulk |
| Test Suite Runs | 3 | Create, retrieve, list executions |
| Sandboxes | 3 | Deploy, upsert/delete scenarios |
| Events | 1 | Publish analytics events |
| Other | 5 | Folders, workspace secrets, uploaded files |
