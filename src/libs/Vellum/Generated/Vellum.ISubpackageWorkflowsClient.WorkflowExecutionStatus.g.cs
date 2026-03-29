#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkflowsClient
    {
        /// <summary>
        /// Workflow Execution Status<br/>
        /// Checks if a workflow execution is currently executing (not fulfilled, not rejected, and has no end time).<br/>
        /// Uses the ClickHouse Prime summary materialized view.
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.CheckWorkflowExecutionStatusResponse> WorkflowExecutionStatusAsync(
            global::System.Guid executionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}