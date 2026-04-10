#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkflowDeploymentsClient
    {
        /// <summary>
        /// Workflow Deployment History Item Retrieve<br/>
        /// DEPRECATED: This endpoint is deprecated and will be removed in a future release. Please use the<br/>
        /// `retrieve_workflow_deployment_release` endpoint instead.
        /// </summary>
        /// <param name="historyIdOrReleaseTag"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.WorkflowDeploymentHistoryItem> WorkflowDeploymentHistoryItemRetrieveAsync(
            global::System.Guid historyIdOrReleaseTag,
            string id,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}