#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkflowExecutionsClient
    {
        /// <summary>
        /// Retrieve Workflow Execution Detail
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="prevSpanId"></param>
        /// <param name="spanLimit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.WorkflowExecutionDetail> RetrieveWorkflowExecutionDetailAsync(
            global::System.Guid executionId,
            global::System.Guid? prevSpanId = default,
            int? spanLimit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}