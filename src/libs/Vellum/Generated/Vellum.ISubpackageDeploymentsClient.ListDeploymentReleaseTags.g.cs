#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDeploymentsClient
    {
        /// <summary>
        /// List Deployment Release Tags<br/>
        /// List Release Tags associated with the specified Prompt Deployment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="ordering"></param>
        /// <param name="source"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.PaginatedDeploymentReleaseTagReadList> ListDeploymentReleaseTagsAsync(
            string id,
            int? limit = default,
            int? offset = default,
            string? ordering = default,
            global::Vellum.V1DeploymentsIdReleaseTagsGetParametersSource? source = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}