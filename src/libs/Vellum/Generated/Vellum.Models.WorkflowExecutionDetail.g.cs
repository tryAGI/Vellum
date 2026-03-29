
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.OneOf<global::Vellum.ParentContext?, object> ParentContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public global::System.DateTime? End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.ExecutionVellumValue> Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.ExecutionVellumValue> Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowError?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.OneOf<global::Vellum.WorkflowError?, object> Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_results")]
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionUsageResult>? UsageResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.VellumSpan> Spans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public object? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionDetail" /> class.
        /// </summary>
        /// <param name="spanId"></param>
        /// <param name="parentContext"></param>
        /// <param name="start"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="error"></param>
        /// <param name="spans"></param>
        /// <param name="end"></param>
        /// <param name="usageResults"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionDetail(
            global::System.Guid spanId,
            global::Vellum.OneOf<global::Vellum.ParentContext?, object> parentContext,
            global::System.DateTime start,
            global::System.Collections.Generic.IList<global::Vellum.ExecutionVellumValue> inputs,
            global::System.Collections.Generic.IList<global::Vellum.ExecutionVellumValue> outputs,
            global::Vellum.OneOf<global::Vellum.WorkflowError?, object> error,
            global::System.Collections.Generic.IList<global::Vellum.VellumSpan> spans,
            global::System.DateTime? end,
            global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionUsageResult>? usageResults,
            object? state)
        {
            this.SpanId = spanId;
            this.ParentContext = parentContext;
            this.Start = start;
            this.End = end;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.Error = error;
            this.UsageResults = usageResults;
            this.Spans = spans ?? throw new global::System.ArgumentNullException(nameof(spans));
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionDetail" /> class.
        /// </summary>
        public WorkflowExecutionDetail()
        {
        }
    }
}