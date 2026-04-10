#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkflowDeploymentsClient
    {
        /// <summary>
        /// Retrieve Workflow Deployment Release<br/>
        /// Retrieve a specific Workflow Deployment Release by either its UUID or the name of a Release Tag that points to it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="releaseIdOrReleaseTag"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.WorkflowDeploymentRelease> RetrieveWorkflowDeploymentReleaseAsync(
            string id,
            string releaseIdOrReleaseTag,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}