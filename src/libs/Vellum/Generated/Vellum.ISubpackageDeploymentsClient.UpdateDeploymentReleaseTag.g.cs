#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDeploymentsClient
    {
        /// <summary>
        /// Update Deployment Release Tag<br/>
        /// Updates an existing Release Tag associated with the specified Prompt Deployment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DeploymentReleaseTagRead> UpdateDeploymentReleaseTagAsync(
            string id,
            string name,

            global::Vellum.PatchedDeploymentReleaseTagUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Deployment Release Tag<br/>
        /// Updates an existing Release Tag associated with the specified Prompt Deployment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="historyItemId">
        /// The ID of the Release to tag
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DeploymentReleaseTagRead> UpdateDeploymentReleaseTagAsync(
            string id,
            string name,
            global::System.Guid? historyItemId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}