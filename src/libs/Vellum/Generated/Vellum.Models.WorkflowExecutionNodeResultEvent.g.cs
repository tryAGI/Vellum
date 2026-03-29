
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A NODE-level event emitted from the workflow's execution.
    /// </summary>
    public sealed partial class WorkflowExecutionNodeResultEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.NodeEnumJsonConverter))]
        public global::Vellum.NodeEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.WorkflowNodeResultEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.WorkflowNodeResultEvent Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionNodeResultEvent" /> class.
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="data"></param>
        /// <param name="runId"></param>
        /// <param name="externalId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionNodeResultEvent(
            string executionId,
            global::Vellum.WorkflowNodeResultEvent data,
            string? runId,
            string? externalId,
            global::Vellum.NodeEnum type)
        {
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
            this.RunId = runId;
            this.ExternalId = externalId;
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionNodeResultEvent" /> class.
        /// </summary>
        public WorkflowExecutionNodeResultEvent()
        {
        }
    }
}