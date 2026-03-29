#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkflowDeploymentsClient
    {
        /// <summary>
        /// Retrieve Workflow Release Tag<br/>
        /// Retrieve a Workflow Release Tag by tag name, associated with a specified Workflow Deployment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.WorkflowReleaseTagRead> RetrieveWorkflowReleaseTagAsync(
            string id,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}