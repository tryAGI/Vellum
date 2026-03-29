#nullable enable

namespace Vellum
{
    public partial interface IVellumClient
    {
        /// <summary>
        /// Execute Workflow Async<br/>
        /// Executes a deployed Workflow asynchronously and returns the execution ID.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.ExecuteWorkflowAsyncResponse> ExecuteWorkflowAsyncAsync(

            global::Vellum.ExecuteWorkflowAsyncRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute Workflow Async<br/>
        /// Executes a deployed Workflow asynchronously and returns the execution ID.
        /// </summary>
        /// <param name="inputs">
        /// The list of inputs defined in the Workflow's Deployment with their corresponding values.
        /// </param>
        /// <param name="workflowDeploymentId">
        /// The ID of the Workflow Deployment. Must provide either this or workflow_deployment_name.
        /// </param>
        /// <param name="workflowDeploymentName">
        /// The name of the Workflow Deployment. Must provide either this or workflow_deployment_id.
        /// </param>
        /// <param name="releaseTag">
        /// Optionally specify a release tag if you want to pin to a specific release of the Workflow Deployment
        /// </param>
        /// <param name="externalId">
        /// Optionally include a unique identifier for tracking purposes. Must be unique within a given Workspace.
        /// </param>
        /// <param name="previousExecutionId">
        /// The ID of a previous Workflow Execution to reference for initial State loading.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary JSON metadata associated with this request. Can be used to capture additional monitoring data such as user id, session id, etc. for future analysis.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.ExecuteWorkflowAsyncResponse> ExecuteWorkflowAsyncAsync(
            global::System.Collections.Generic.IList<global::Vellum.WorkflowRequestInputRequest> inputs,
            global::System.Guid? workflowDeploymentId = default,
            string? workflowDeploymentName = default,
            string? releaseTag = default,
            string? externalId = default,
            global::System.Guid? previousExecutionId = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}