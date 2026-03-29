#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkflowDeploymentsClient
    {
        /// <summary>
        /// Workflow Deployment Event Execution
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.WorkflowEventExecutionRead> WorkflowDeploymentEventExecutionAsync(
            global::System.Guid executionId,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}