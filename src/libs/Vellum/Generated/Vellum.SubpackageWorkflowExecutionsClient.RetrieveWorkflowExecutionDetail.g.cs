
#nullable enable

namespace Vellum
{
    public partial class SubpackageWorkflowExecutionsClient
    {
        partial void PrepareRetrieveWorkflowExecutionDetailArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid executionId,
            ref global::System.Guid? prevSpanId,
            ref int? spanLimit);
        partial void PrepareRetrieveWorkflowExecutionDetailRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid executionId,
            global::System.Guid? prevSpanId,
            int? spanLimit);
        partial void ProcessRetrieveWorkflowExecutionDetailResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRetrieveWorkflowExecutionDetailResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve Workflow Execution Detail
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="prevSpanId"></param>
        /// <param name="spanLimit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vellum.WorkflowExecutionDetail> RetrieveWorkflowExecutionDetailAsync(
            global::System.Guid executionId,
            global::System.Guid? prevSpanId = default,
            int? spanLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRetrieveWorkflowExecutionDetailArguments(
                httpClient: HttpClient,
                executionId: ref executionId,
                prevSpanId: ref prevSpanId,
                spanLimit: ref spanLimit);

            var __pathBuilder = new global::Vellum.PathBuilder(
                path: $"/v1/workflow-executions/{executionId}/detail",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("prev_span_id", prevSpanId?.ToString())
                .AddOptionalParameter("span_limit", spanLimit?.ToString()) 
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
            PrepareRetrieveWorkflowExecutionDetailRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                executionId: executionId,
                prevSpanId: prevSpanId,
                spanLimit: spanLimit);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRetrieveWorkflowExecutionDetailResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::Vellum.ErrorDetailResponse? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::Vellum.ErrorDetailResponse.FromJson(__content_404, JsonSerializerContext);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::Vellum.ErrorDetailResponse.FromJson(__content_404, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::Vellum.ApiException<global::Vellum.ErrorDetailResponse>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 421)
            {
                string? __content_421 = null;
                global::System.Exception? __exception_421 = null;
                global::Vellum.UpdateActiveWorkspaceResponse? __value_421 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_421 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_421 = global::Vellum.UpdateActiveWorkspaceResponse.FromJson(__content_421, JsonSerializerContext);
                    }
                    else
                    {
                        __content_421 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_421 = global::Vellum.UpdateActiveWorkspaceResponse.FromJson(__content_421, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_421 = __ex;
                }

                throw new global::Vellum.ApiException<global::Vellum.UpdateActiveWorkspaceResponse>(
                    message: __content_421 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_421,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_421,
                    ResponseObject = __value_421,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessRetrieveWorkflowExecutionDetailResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vellum.WorkflowExecutionDetail.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Vellum.WorkflowExecutionDetail.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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