
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionFulfilledBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumCodeResourceDefinition WorkflowDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final_state")]
        public object? FinalState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_metadata")]
        public object? ServerMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted")]
        public bool? Redacted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionFulfilledBody" /> class.
        /// </summary>
        /// <param name="workflowDefinition"></param>
        /// <param name="outputs"></param>
        /// <param name="finalState"></param>
        /// <param name="serverMetadata"></param>
        /// <param name="redacted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionFulfilledBody(
            global::Vellum.VellumCodeResourceDefinition workflowDefinition,
            object outputs,
            object? finalState,
            object? serverMetadata,
            bool? redacted)
        {
            this.WorkflowDefinition = workflowDefinition ?? throw new global::System.ArgumentNullException(nameof(workflowDefinition));
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.FinalState = finalState;
            this.ServerMetadata = serverMetadata;
            this.Redacted = redacted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionFulfilledBody" /> class.
        /// </summary>
        public WorkflowExecutionFulfilledBody()
        {
        }
    }
}