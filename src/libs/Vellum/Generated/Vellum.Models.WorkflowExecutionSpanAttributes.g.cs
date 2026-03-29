
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionSpanAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkflowId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionSpanAttributes" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="workflowId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionSpanAttributes(
            string label,
            global::System.Guid workflowId)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.WorkflowId = workflowId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionSpanAttributes" /> class.
        /// </summary>
        public WorkflowExecutionSpanAttributes()
        {
        }
    }
}