
#nullable enable

namespace Vellum
{
    /// <summary>
    /// An event that indicates that the node has execution is in progress.
    /// </summary>
    public sealed partial class StreamingWorkflowNodeResultEvent
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.StreamingEnumJsonConverter))]
        public global::Vellum.StreamingEnum State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ts")]
        public global::System.DateTime? Ts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Vellum.WorkflowNodeResultData? Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_execution_id")]
        public string? SourceExecutionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Vellum.NodeOutputCompiledValue? Output { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingWorkflowNodeResultEvent" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="nodeResultId"></param>
        /// <param name="state"></param>
        /// <param name="ts"></param>
        /// <param name="data"></param>
        /// <param name="sourceExecutionId"></param>
        /// <param name="output"></param>
        /// <param name="outputIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamingWorkflowNodeResultEvent(
            string id,
            string nodeId,
            string nodeResultId,
            global::Vellum.StreamingEnum state,
            global::System.DateTime? ts,
            global::Vellum.WorkflowNodeResultData? data,
            string? sourceExecutionId,
            global::Vellum.NodeOutputCompiledValue? output,
            int? outputIndex)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.NodeResultId = nodeResultId ?? throw new global::System.ArgumentNullException(nameof(nodeResultId));
            this.State = state;
            this.Ts = ts;
            this.Data = data;
            this.SourceExecutionId = sourceExecutionId;
            this.Output = output;
            this.OutputIndex = outputIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingWorkflowNodeResultEvent" /> class.
        /// </summary>
        public StreamingWorkflowNodeResultEvent()
        {
        }

    }
}