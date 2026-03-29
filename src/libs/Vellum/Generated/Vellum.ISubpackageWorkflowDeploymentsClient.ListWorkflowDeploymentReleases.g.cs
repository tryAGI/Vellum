#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkflowDeploymentsClient
    {
        /// <summary>
        /// List Workflow Deployment Releases<br/>
        /// List the Releases of the specified Workflow Deployment for the current Environment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="ordering"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.PaginatedWorkflowDeploymentReleaseList> ListWorkflowDeploymentReleasesAsync(
            string id,
            int? limit = default,
            int? offset = default,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}