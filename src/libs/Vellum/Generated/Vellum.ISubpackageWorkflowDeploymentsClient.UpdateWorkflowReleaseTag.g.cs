#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkflowDeploymentsClient
    {
        /// <summary>
        /// Update Workflow Release Tag<br/>
        /// Updates an existing Release Tag associated with the specified Workflow Deployment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.WorkflowReleaseTagRead> UpdateWorkflowReleaseTagAsync(
            string id,
            string name,

            global::Vellum.PatchedWorkflowReleaseTagUpdateRequest request,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Workflow Release Tag<br/>
        /// Updates an existing Release Tag associated with the specified Workflow Deployment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="historyItemId">
        /// The ID of the Workflow Deployment History Item to tag
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.WorkflowReleaseTagRead> UpdateWorkflowReleaseTagAsync(
            string id,
            string name,
            global::System.Guid? historyItemId = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}