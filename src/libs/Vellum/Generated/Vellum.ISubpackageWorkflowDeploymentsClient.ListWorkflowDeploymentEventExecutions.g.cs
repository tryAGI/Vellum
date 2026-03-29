#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkflowDeploymentsClient
    {
        /// <summary>
        /// List Workflow Deployment Event Executions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="filters"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="ordering"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.WorkflowDeploymentEventExecutionsResponse> ListWorkflowDeploymentEventExecutionsAsync(
            string id,
            string? filters = default,
            int? limit = default,
            int? offset = default,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}