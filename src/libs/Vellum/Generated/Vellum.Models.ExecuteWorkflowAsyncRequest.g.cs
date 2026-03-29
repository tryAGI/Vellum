
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The request to execute a Workflow Deployment asynchronously.
    /// </summary>
    public sealed partial class ExecuteWorkflowAsyncRequest
    {
        /// <summary>
        /// The list of inputs defined in the Workflow's Deployment with their corresponding values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.WorkflowRequestInputRequest> Inputs { get; set; }

        /// <summary>
        /// The ID of the Workflow Deployment. Must provide either this or workflow_deployment_name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_deployment_id")]
        public global::System.Guid? WorkflowDeploymentId { get; set; }

        /// <summary>
        /// The name of the Workflow Deployment. Must provide either this or workflow_deployment_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_deployment_name")]
        public string? WorkflowDeploymentName { get; set; }

        /// <summary>
        /// Optionally specify a release tag if you want to pin to a specific release of the Workflow Deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_tag")]
        public string? ReleaseTag { get; set; }

        /// <summary>
        /// Optionally include a unique identifier for tracking purposes. Must be unique within a given Workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// The ID of a previous Workflow Execution to reference for initial State loading.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_execution_id")]
        public global::System.Guid? PreviousExecutionId { get; set; }

        /// <summary>
        /// Arbitrary JSON metadata associated with this request. Can be used to capture additional monitoring data such as user id, session id, etc. for future analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteWorkflowAsyncRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteWorkflowAsyncRequest(
            global::System.Collections.Generic.IList<global::Vellum.WorkflowRequestInputRequest> inputs,
            global::System.Guid? workflowDeploymentId,
            string? workflowDeploymentName,
            string? releaseTag,
            string? externalId,
            global::System.Guid? previousExecutionId,
            object? metadata)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.WorkflowDeploymentId = workflowDeploymentId;
            this.WorkflowDeploymentName = workflowDeploymentName;
            this.ReleaseTag = releaseTag;
            this.ExternalId = externalId;
            this.PreviousExecutionId = previousExecutionId;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteWorkflowAsyncRequest" /> class.
        /// </summary>
        public ExecuteWorkflowAsyncRequest()
        {
        }
    }
}