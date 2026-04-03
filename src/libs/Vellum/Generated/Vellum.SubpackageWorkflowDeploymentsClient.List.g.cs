
#nullable enable

namespace Vellum
{
    public partial class SubpackageWorkflowDeploymentsClient
    {
        partial void PrepareListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? hasStoryConfig,
            ref string? isPublic,
            ref int? limit,
            ref int? offset,
            ref string? ordering,
            ref string? ownedBy,
            ref global::Vellum.V1WorkflowDeploymentsGetParametersStatus? status);
        partial void PrepareListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? hasStoryConfig,
            string? isPublic,
            int? limit,
            int? offset,
            string? ordering,
            string? ownedBy,
            global::Vellum.V1WorkflowDeploymentsGetParametersStatus? status);
        partial void ProcessListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List<br/>
        /// Used to list all Workflow Deployments.
        /// </summary>
        /// <param name="hasStoryConfig"></param>
        /// <param name="isPublic"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="ordering"></param>
        /// <param name="ownedBy"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vellum.PaginatedSlimWorkflowDeploymentList> ListAsync(
            string? hasStoryConfig = default,
            string? isPublic = default,
            int? limit = default,
            int? offset = default,
            string? ordering = default,
            string? ownedBy = default,
            global::Vellum.V1WorkflowDeploymentsGetParametersStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListArguments(
                httpClient: HttpClient,
                hasStoryConfig: ref hasStoryConfig,
                isPublic: ref isPublic,
                limit: ref limit,
                offset: ref offset,
                ordering: ref ordering,
                ownedBy: ref ownedBy,
                status: ref status);

            var __pathBuilder = new global::Vellum.PathBuilder(
                path: "/v1/workflow-deployments",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("has_story_config", hasStoryConfig)
                .AddOptionalParameter("is_public", isPublic)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("offset", offset?.ToString())
                .AddOptionalParameter("ordering", ordering)
                .AddOptionalParameter("owned_by", ownedBy)
                .AddOptionalParameter("status", status?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                hasStoryConfig: hasStoryConfig,
                isPublic: isPublic,
                limit: limit,
                offset: offset,
                ordering: ordering,
                ownedBy: ownedBy,
                status: status);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vellum.PaginatedSlimWorkflowDeploymentList.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Vellum.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Vellum.PaginatedSlimWorkflowDeploymentList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Vellum.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}