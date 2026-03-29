
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The request to execute a Workflow Deployment stream.
    /// </summary>
    public sealed partial class ExecuteWorkflowDeploymentStreamRequest
    {
        /// <summary>
        /// A mapping from input name to value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// The name or ID of a workflow trigger to use for this execution. If not specified, then a default manual trigger will be chosen.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public string? Trigger { get; set; }

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
        /// Arbitrary JSON metadata associated with this request. Can be used to capture additional monitoring data such as user id, session id, etc. for future analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The ID of a previous workflow execution to reference for context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_execution_id")]
        public global::System.Guid? PreviousExecutionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteWorkflowDeploymentStreamRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteWorkflowDeploymentStreamRequest(
            object? inputs,
            string? trigger,
            string? releaseTag,
            string? externalId,
            object? metadata,
            global::System.Guid? previousExecutionId)
        {
            this.Inputs = inputs;
            this.Trigger = trigger;
            this.ReleaseTag = releaseTag;
            this.ExternalId = externalId;
            this.Metadata = metadata;
            this.PreviousExecutionId = previousExecutionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteWorkflowDeploymentStreamRequest" /> class.
        /// </summary>
        public ExecuteWorkflowDeploymentStreamRequest()
        {
        }
    }
}