#nullable enable

namespace Vellum
{
    public partial interface IVellumClient
    {
        /// <summary>
        /// Execute Workflow Stream<br/>
        /// Executes a deployed Workflow and streams back its results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Vellum.WorkflowStreamEvent> ExecuteWorkflowStreamAsync(

            global::Vellum.ExecuteWorkflowStreamRequest request,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute Workflow Stream<br/>
        /// Executes a deployed Workflow and streams back its results.
        /// </summary>
        /// <param name="inputs">
        /// The list of inputs defined in the Workflow's Deployment with their corresponding values.
        /// </param>
        /// <param name="expandMeta">
        /// An optionally specified configuration used to opt in to including additional metadata about this workflow execution in the API response. Corresponding values will be returned under the `execution_meta` key within NODE events in the response stream.
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
        /// <param name="eventTypes">
        /// Optionally specify which events you want to receive. Defaults to only WORKFLOW events. Note that the schema of non-WORKFLOW events is unstable and should be used with caution.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary JSON metadata associated with this request. Can be used to capture additional monitoring data such as user id, session id, etc. for future analysis.
        /// </param>
        /// <param name="previousExecutionId">
        /// The ID of a previous Workflow Execution to reference for initial State loading.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Vellum.WorkflowStreamEvent> ExecuteWorkflowStreamAsync(
            global::System.Collections.Generic.IList<global::Vellum.WorkflowRequestInputRequest> inputs,
            global::Vellum.OneOf<global::Vellum.WorkflowExpandMetaRequest, object>? expandMeta = default,
            global::System.Guid? workflowDeploymentId = default,
            string? workflowDeploymentName = default,
            string? releaseTag = default,
            string? externalId = default,
            global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionEventType>? eventTypes = default,
            object? metadata = default,
            global::System.Guid? previousExecutionId = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}