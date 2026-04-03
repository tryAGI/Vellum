
#nullable enable

namespace Vellum
{
    public partial class SubpackageWorkflowDeploymentsClient
    {
        partial void PrepareUpdateWorkflowReleaseTagArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            ref string name,
            global::Vellum.PatchedWorkflowReleaseTagUpdateRequest request);
        partial void PrepareUpdateWorkflowReleaseTagRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            string name,
            global::Vellum.PatchedWorkflowReleaseTagUpdateRequest request);
        partial void ProcessUpdateWorkflowReleaseTagResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateWorkflowReleaseTagResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Workflow Release Tag<br/>
        /// Updates an existing Release Tag associated with the specified Workflow Deployment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vellum.WorkflowReleaseTagRead> UpdateWorkflowReleaseTagAsync(
            string id,
            string name,

            global::Vellum.PatchedWorkflowReleaseTagUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateWorkflowReleaseTagArguments(
                httpClient: HttpClient,
                id: ref id,
                name: ref name,
                request: request);

            var __pathBuilder = new global::Vellum.PathBuilder(
                path: $"/v1/workflow-deployments/{id}/release-tags/{name}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateWorkflowReleaseTagRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                name: name,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateWorkflowReleaseTagResponse(
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
                ProcessUpdateWorkflowReleaseTagResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vellum.WorkflowReleaseTagRead.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Vellum.WorkflowReleaseTagRead.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// <summary>
        /// Update Workflow Release Tag<br/>
        /// Updates an existing Release Tag associated with the specified Workflow Deployment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="historyItemId">
        /// The ID of the Workflow Deployment History Item to tag
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vellum.WorkflowReleaseTagRead> UpdateWorkflowReleaseTagAsync(
            string id,
            string name,
            global::System.Guid? historyItemId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vellum.PatchedWorkflowReleaseTagUpdateRequest
            {
                HistoryItemId = historyItemId,
            };

            return await UpdateWorkflowReleaseTagAsync(
                id: id,
                name: name,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}