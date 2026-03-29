#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkflowDeploymentsClient
    {
        /// <summary>
        /// Execute Stream<br/>
        /// Executes a deployed Workflow and streams back its results.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Vellum.WorkflowEvent> ExecuteStreamAsync(
            string id,

            global::Vellum.ExecuteWorkflowDeploymentStreamRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute Stream<br/>
        /// Executes a deployed Workflow and streams back its results.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inputs">
        /// A mapping from input name to value.
        /// </param>
        /// <param name="trigger">
        /// The name or ID of a workflow trigger to use for this execution. If not specified, then a default manual trigger will be chosen.
        /// </param>
        /// <param name="releaseTag">
        /// Optionally specify a release tag if you want to pin to a specific release of the Workflow Deployment
        /// </param>
        /// <param name="externalId">
        /// Optionally include a unique identifier for tracking purposes. Must be unique within a given Workspace.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary JSON metadata associated with this request. Can be used to capture additional monitoring data such as user id, session id, etc. for future analysis.
        /// </param>
        /// <param name="previousExecutionId">
        /// The ID of a previous workflow execution to reference for context.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Vellum.WorkflowEvent> ExecuteStreamAsync(
            string id,
            object? inputs = default,
            string? trigger = default,
            string? releaseTag = default,
            string? externalId = default,
            object? metadata = default,
            global::System.Guid? previousExecutionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}