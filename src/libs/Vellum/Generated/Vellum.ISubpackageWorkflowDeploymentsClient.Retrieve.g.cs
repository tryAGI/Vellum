#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkflowDeploymentsClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Used to retrieve a workflow deployment given its ID or name.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.WorkflowDeploymentRead> RetrieveAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}