#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkflowDeploymentsClient
    {
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.PaginatedSlimWorkflowDeploymentList> ListAsync(
            string? hasStoryConfig = default,
            string? isPublic = default,
            int? limit = default,
            int? offset = default,
            string? ordering = default,
            string? ownedBy = default,
            global::Vellum.V1WorkflowDeploymentsGetParametersStatus? status = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}