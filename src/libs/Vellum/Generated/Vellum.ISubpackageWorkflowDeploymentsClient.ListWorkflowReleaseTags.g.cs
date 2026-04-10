#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkflowDeploymentsClient
    {
        /// <summary>
        /// List Workflow Release Tags<br/>
        /// List Release Tags associated with the specified Workflow Deployment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="ordering"></param>
        /// <param name="source"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.PaginatedWorkflowReleaseTagReadList> ListWorkflowReleaseTagsAsync(
            string id,
            int? limit = default,
            int? offset = default,
            string? ordering = default,
            global::Vellum.V1WorkflowDeploymentsIdReleaseTagsGetParametersSource? source = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}