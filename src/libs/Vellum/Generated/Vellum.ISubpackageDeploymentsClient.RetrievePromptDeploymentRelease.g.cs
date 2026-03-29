#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDeploymentsClient
    {
        /// <summary>
        /// Retrieve Prompt Deployment Release<br/>
        /// Retrieve a specific Prompt Deployment Release by either its UUID or the name of a Release Tag that points to it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="releaseIdOrReleaseTag"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.PromptDeploymentRelease> RetrievePromptDeploymentReleaseAsync(
            string id,
            string releaseIdOrReleaseTag,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}