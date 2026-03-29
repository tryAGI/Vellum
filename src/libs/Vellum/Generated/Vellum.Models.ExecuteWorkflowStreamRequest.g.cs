
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The request to stream a Workflow Deployment execution.
    /// </summary>
    public sealed partial class ExecuteWorkflowStreamRequest
    {
        /// <summary>
        /// The list of inputs defined in the Workflow's Deployment with their corresponding values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.WorkflowRequestInputRequest> Inputs { get; set; }

        /// <summary>
        /// An optionally specified configuration used to opt in to including additional metadata about this workflow execution in the API response. Corresponding values will be returned under the `execution_meta` key within NODE events in the response stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand_meta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowExpandMetaRequest, object>))]
        public global::Vellum.OneOf<global::Vellum.WorkflowExpandMetaRequest, object>? ExpandMeta { get; set; }

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
        /// Optionally specify which events you want to receive. Defaults to only WORKFLOW events. Note that the schema of non-WORKFLOW events is unstable and should be used with caution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_types")]
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionEventType>? EventTypes { get; set; }

        /// <summary>
        /// Arbitrary JSON metadata associated with this request. Can be used to capture additional monitoring data such as user id, session id, etc. for future analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The ID of a previous Workflow Execution to reference for initial State loading.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_execution_id")]
        public global::System.Guid? PreviousExecutionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteWorkflowStreamRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteWorkflowStreamRequest(
            global::System.Collections.Generic.IList<global::Vellum.WorkflowRequestInputRequest> inputs,
            global::Vellum.OneOf<global::Vellum.WorkflowExpandMetaRequest, object>? expandMeta,
            global::System.Guid? workflowDeploymentId,
            string? workflowDeploymentName,
            string? releaseTag,
            string? externalId,
            global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionEventType>? eventTypes,
            object? metadata,
            global::System.Guid? previousExecutionId)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.ExpandMeta = expandMeta;
            this.WorkflowDeploymentId = workflowDeploymentId;
            this.WorkflowDeploymentName = workflowDeploymentName;
            this.ReleaseTag = releaseTag;
            this.ExternalId = externalId;
            this.EventTypes = eventTypes;
            this.Metadata = metadata;
            this.PreviousExecutionId = previousExecutionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteWorkflowStreamRequest" /> class.
        /// </summary>
        public ExecuteWorkflowStreamRequest()
        {
        }
    }
}