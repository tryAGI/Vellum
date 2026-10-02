#nullable enable

namespace Vellum
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Pull<br/>
        /// Used to pull the definition of a Workflow from Vellum. Returns a zip archive of the Workflow's code by default, or a flattened plain-text representation if the Accept header is set to 'text/plain'.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="excludeCode"></param>
        /// <param name="excludeDisplay"></param>
        /// <param name="includeJson"></param>
        /// <param name="includeSandbox"></param>
        /// <param name="releaseTag"></param>
        /// <param name="strict"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> PullAsync(
            string id,
            bool? excludeCode = default,
            bool? excludeDisplay = default,
            bool? includeJson = default,
            bool? includeSandbox = default,
            string? releaseTag = default,
            bool? strict = default,
            string? version = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pull<br/>
        /// Used to pull the definition of a Workflow from Vellum. Returns a zip archive of the Workflow's code by default, or a flattened plain-text representation if the Accept header is set to 'text/plain'.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="excludeCode"></param>
        /// <param name="excludeDisplay"></param>
        /// <param name="includeJson"></param>
        /// <param name="includeSandbox"></param>
        /// <param name="releaseTag"></param>
        /// <param name="strict"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> PullAsStreamAsync(
            string id,
            bool? excludeCode = default,
            bool? excludeDisplay = default,
            bool? includeJson = default,
            bool? includeSandbox = default,
            string? releaseTag = default,
            bool? strict = default,
            string? version = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pull<br/>
        /// Used to pull the definition of a Workflow from Vellum. Returns a zip archive of the Workflow's code by default, or a flattened plain-text representation if the Accept header is set to 'text/plain'.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="excludeCode"></param>
        /// <param name="excludeDisplay"></param>
        /// <param name="includeJson"></param>
        /// <param name="includeSandbox"></param>
        /// <param name="releaseTag"></param>
        /// <param name="strict"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.AutoSDKHttpResponse<byte[]>> PullAsResponseAsync(
            string id,
            bool? excludeCode = default,
            bool? excludeDisplay = default,
            bool? includeJson = default,
            bool? includeSandbox = default,
            string? releaseTag = default,
            bool? strict = default,
            string? version = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}