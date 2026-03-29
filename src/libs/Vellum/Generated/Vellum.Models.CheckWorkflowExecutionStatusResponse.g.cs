
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Response serializer for workflow execution status check.
    /// </summary>
    public sealed partial class CheckWorkflowExecutionStatusResponse
    {
        /// <summary>
        /// * `INITIATED` - Initiated<br/>
        /// * `STREAMING` - Streaming<br/>
        /// * `FULFILLED` - Fulfilled<br/>
        /// * `REJECTED` - Rejected<br/>
        /// * `PENDING` - Pending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.WorkflowResultEventStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.WorkflowResultEventState Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.CheckWorkflowExecutionStatusError, object>))]
        public global::Vellum.OneOf<global::Vellum.CheckWorkflowExecutionStatusError, object>? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_detail_url")]
        public string? ExecutionDetailUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckWorkflowExecutionStatusResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// * `INITIATED` - Initiated<br/>
        /// * `STREAMING` - Streaming<br/>
        /// * `FULFILLED` - Fulfilled<br/>
        /// * `REJECTED` - Rejected<br/>
        /// * `PENDING` - Pending
        /// </param>
        /// <param name="executionId"></param>
        /// <param name="outputs"></param>
        /// <param name="error"></param>
        /// <param name="executionDetailUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckWorkflowExecutionStatusResponse(
            global::Vellum.WorkflowResultEventState status,
            string executionId,
            object? outputs,
            global::Vellum.OneOf<global::Vellum.CheckWorkflowExecutionStatusError, object>? error,
            string? executionDetailUrl)
        {
            this.Status = status;
            this.Outputs = outputs;
            this.Error = error;
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
            this.ExecutionDetailUrl = executionDetailUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckWorkflowExecutionStatusResponse" /> class.
        /// </summary>
        public CheckWorkflowExecutionStatusResponse()
        {
        }
    }
}