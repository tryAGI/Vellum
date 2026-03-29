
#nullable enable

namespace Vellum
{
    public partial class VellumClient
    {
        partial void PrepareSubmitWorkflowExecutionActualsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Vellum.SubmitWorkflowExecutionActualsRequest request);
        partial void PrepareSubmitWorkflowExecutionActualsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Vellum.SubmitWorkflowExecutionActualsRequest request);
        partial void ProcessSubmitWorkflowExecutionActualsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSubmitWorkflowExecutionActualsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Submit Workflow Execution Actuals<br/>
        ///     Used to submit feedback regarding the quality of previous workflow execution and its outputs.<br/>
        ///     **Note:** Uses a base url of `https://predict.vellum.ai`.    
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vellum.SubmitWorkflowExecutionActualsResponse200> SubmitWorkflowExecutionActualsAsync(

            global::Vellum.SubmitWorkflowExecutionActualsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSubmitWorkflowExecutionActualsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Vellum.PathBuilder(
                path: "/v1/submit-workflow-execution-actuals",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareSubmitWorkflowExecutionActualsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSubmitWorkflowExecutionActualsResponse(
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
                ProcessSubmitWorkflowExecutionActualsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vellum.SubmitWorkflowExecutionActualsResponse200.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Vellum.SubmitWorkflowExecutionActualsResponse200.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Submit Workflow Execution Actuals<br/>
        ///     Used to submit feedback regarding the quality of previous workflow execution and its outputs.<br/>
        ///     **Note:** Uses a base url of `https://predict.vellum.ai`.    
        /// </summary>
        /// <param name="actuals">
        /// Feedback regarding the quality of an output on a previously executed workflow.
        /// </param>
        /// <param name="executionId">
        /// The Vellum-generated ID of a previously executed workflow. Must provide either this or external_id.
        /// </param>
        /// <param name="externalId">
        /// The external ID that was originally provided by when executing the workflow, if applicable, that you'd now like to submit actuals for. Must provide either this or execution_id.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vellum.SubmitWorkflowExecutionActualsResponse200> SubmitWorkflowExecutionActualsAsync(
            global::System.Collections.Generic.IList<global::Vellum.SubmitWorkflowExecutionActualRequest> actuals,
            global::System.Guid? executionId = default,
            string? externalId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vellum.SubmitWorkflowExecutionActualsRequest
            {
                Actuals = actuals,
                ExecutionId = executionId,
                ExternalId = externalId,
            };

            return await SubmitWorkflowExecutionActualsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}