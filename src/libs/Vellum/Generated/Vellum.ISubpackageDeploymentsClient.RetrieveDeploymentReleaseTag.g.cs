#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDeploymentsClient
    {
        /// <summary>
        /// Retrieve Deployment Release Tag<br/>
        /// Retrieve a Deployment Release Tag by tag name, associated with a specified Deployment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DeploymentReleaseTagRead> RetrieveDeploymentReleaseTagAsync(
            string id,
            string name,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}