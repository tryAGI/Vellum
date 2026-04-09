
#nullable enable

namespace Vellum
{
    public partial class VellumClient
    {


        private static readonly global::Vellum.EndPointSecurityRequirement s_ExecutePromptStreamSecurityRequirement0 =
            new global::Vellum.EndPointSecurityRequirement
            {
                Authorizations = new global::Vellum.EndPointAuthorizationRequirement[]
                {                    new global::Vellum.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "X-API-KEY",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::Vellum.EndPointSecurityRequirement[] s_ExecutePromptStreamSecurityRequirements =
            new global::Vellum.EndPointSecurityRequirement[]
            {                s_ExecutePromptStreamSecurityRequirement0,
            };
        partial void PrepareExecutePromptStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Vellum.ExecutePromptStreamRequest request);
        partial void PrepareExecutePromptStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Vellum.ExecutePromptStreamRequest request);
        partial void ProcessExecutePromptStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Execute Prompt Stream<br/>
        /// Executes a deployed Prompt and streams back the results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Vellum.ExecutePromptEvent> ExecutePromptStreamAsync(

            global::Vellum.ExecutePromptStreamRequest request,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareExecutePromptStreamArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Vellum.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ExecutePromptStreamSecurityRequirements,
                operationName: "ExecutePromptStreamAsync");

            var __pathBuilder = new global::Vellum.PathBuilder(
                path: "/v1/execute-prompt-stream",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareExecutePromptStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessExecutePromptStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
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

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);

            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                .Create(__stream).EnumerateAsync(cancellationToken))
            {
                var __content = __sseEvent.Data;
                if (__content == "[DONE]")
                {
                    yield break;
                }

                var __streamedResponse = global::Vellum.ExecutePromptEvent.FromJson(__content, JsonSerializerContext) ??
                                       throw new global::Vellum.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
            }
        }
        /// <summary>
        /// Execute Prompt Stream<br/>
        /// Executes a deployed Prompt and streams back the results.
        /// </summary>
        /// <param name="inputs">
        /// A list consisting of the Prompt Deployment's input variables and their values.
        /// </param>
        /// <param name="promptDeploymentId">
        /// The ID of the Prompt Deployment. Must provide either this or prompt_deployment_name.
        /// </param>
        /// <param name="promptDeploymentName">
        /// The unique name of the Prompt Deployment. Must provide either this or prompt_deployment_id.
        /// </param>
        /// <param name="releaseTag">
        /// Optionally specify a release tag if you want to pin to a specific release of the Prompt Deployment
        /// </param>
        /// <param name="externalId">
        /// Optionally include a unique identifier for tracking purposes. Must be unique within a given Workspace.
        /// </param>
        /// <param name="expandMeta">
        /// An optionally specified configuration used to opt in to including additional metadata about this prompt execution in the API response. Corresponding values will be returned under the `meta` key of the API response.
        /// </param>
        /// <param name="rawOverrides">
        /// Overrides for the raw API request sent to the model host. Combined with `expand_raw`, it can be used to access new features from models.
        /// </param>
        /// <param name="expandRaw">
        /// A list of keys whose values you'd like to directly return from the JSON response of the model provider. Useful if you need lower-level info returned by model providers that Vellum would otherwise omit. Corresponding key/value pairs will be returned under the `raw` key of the API response.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary JSON metadata associated with this request. Can be used to capture additional monitoring data such as user id, session id, etc. for future analysis.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Vellum.ExecutePromptEvent> ExecutePromptStreamAsync(
            global::System.Collections.Generic.IList<global::Vellum.PromptDeploymentInputRequest> inputs,
            global::System.Guid? promptDeploymentId = default,
            string? promptDeploymentName = default,
            string? releaseTag = default,
            string? externalId = default,
            global::Vellum.OneOf<global::Vellum.PromptDeploymentExpandMetaRequest, object>? expandMeta = default,
            global::Vellum.OneOf<global::Vellum.RawPromptExecutionOverridesRequest, object>? rawOverrides = default,
            global::System.Collections.Generic.IList<string>? expandRaw = default,
            object? metadata = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vellum.ExecutePromptStreamRequest
            {
                Inputs = inputs,
                PromptDeploymentId = promptDeploymentId,
                PromptDeploymentName = promptDeploymentName,
                ReleaseTag = releaseTag,
                ExternalId = externalId,
                ExpandMeta = expandMeta,
                RawOverrides = rawOverrides,
                ExpandRaw = expandRaw,
                Metadata = metadata,
            };

            var __enumerable = ExecutePromptStreamAsync(
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}