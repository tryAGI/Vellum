#nullable enable

namespace Vellum
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Pull<br/>
        /// Used to pull the definition of a Prompt from Vellum.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="promptVariantId"></param>
        /// <param name="releaseTag"></param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.PromptExecConfig> PullAsync(
            string id,
            string? promptVariantId = default,
            string? releaseTag = default,
            string? accept = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pull<br/>
        /// Used to pull the definition of a Prompt from Vellum.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="promptVariantId"></param>
        /// <param name="releaseTag"></param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.AutoSDKHttpResponse<global::Vellum.PromptExecConfig>> PullAsResponseAsync(
            string id,
            string? promptVariantId = default,
            string? releaseTag = default,
            string? accept = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}