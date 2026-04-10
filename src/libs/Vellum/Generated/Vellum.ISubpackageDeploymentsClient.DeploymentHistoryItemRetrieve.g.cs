#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDeploymentsClient
    {
        /// <summary>
        /// Deployment History Item Retrieve<br/>
        /// DEPRECATED: This endpoint is deprecated and will be removed in a future release. Please use the<br/>
        /// `retrieve_prompt_deployment_release` xendpoint instead.
        /// </summary>
        /// <param name="historyIdOrReleaseTag"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DeploymentHistoryItem> DeploymentHistoryItemRetrieveAsync(
            global::System.Guid historyIdOrReleaseTag,
            string id,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}