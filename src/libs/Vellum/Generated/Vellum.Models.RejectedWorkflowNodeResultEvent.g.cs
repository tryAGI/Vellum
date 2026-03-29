
#nullable enable

namespace Vellum
{
    /// <summary>
    /// An event that indicates that the node has rejected its execution.
    /// </summary>
    public sealed partial class RejectedWorkflowNodeResultEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_result_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeResultId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.RejectedEnumJsonConverter))]
        public global::Vellum.RejectedEnum State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ts")]
        public global::System.DateTime? Ts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowNodeResultData?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.OneOf<global::Vellum.WorkflowNodeResultData?, object> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_execution_id")]
        public string? SourceExecutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.WorkflowEventError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectedWorkflowNodeResultEvent" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="nodeResultId"></param>
        /// <param name="data"></param>
        /// <param name="error"></param>
        /// <param name="state"></param>
        /// <param name="ts"></param>
        /// <param name="sourceExecutionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RejectedWorkflowNodeResultEvent(
            string id,
            string nodeId,
            string nodeResultId,
            global::Vellum.OneOf<global::Vellum.WorkflowNodeResultData?, object> data,
            global::Vellum.WorkflowEventError error,
            global::Vellum.RejectedEnum state,
            global::System.DateTime? ts,
            string? sourceExecutionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.NodeResultId = nodeResultId ?? throw new global::System.ArgumentNullException(nameof(nodeResultId));
            this.State = state;
            this.Ts = ts;
            this.Data = data;
            this.SourceExecutionId = sourceExecutionId;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectedWorkflowNodeResultEvent" /> class.
        /// </summary>
        public RejectedWorkflowNodeResultEvent()
        {
        }
    }
}