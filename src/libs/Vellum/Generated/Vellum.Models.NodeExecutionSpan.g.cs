
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeExecutionSpan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.NodeExecutionEnumJsonConverter))]
        public global::Vellum.NodeExecutionEnum Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.VellumNodeExecutionEvent> Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.NodeExecutionSpanAttributes Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowExecutionUsageCalculationFulfilledBody, object>))]
        public global::Vellum.OneOf<global::Vellum.WorkflowExecutionUsageCalculationFulfilledBody, object>? UsageResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_ts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_ts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_span_id")]
        public global::System.Guid? ParentSpanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecutionSpan" /> class.
        /// </summary>
        /// <param name="events"></param>
        /// <param name="attributes"></param>
        /// <param name="spanId"></param>
        /// <param name="startTs"></param>
        /// <param name="endTs"></param>
        /// <param name="name"></param>
        /// <param name="usageResult"></param>
        /// <param name="parentSpanId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeExecutionSpan(
            global::System.Collections.Generic.IList<global::Vellum.VellumNodeExecutionEvent> events,
            global::Vellum.NodeExecutionSpanAttributes attributes,
            global::System.Guid spanId,
            global::System.DateTime startTs,
            global::System.DateTime endTs,
            global::Vellum.NodeExecutionEnum name,
            global::Vellum.OneOf<global::Vellum.WorkflowExecutionUsageCalculationFulfilledBody, object>? usageResult,
            global::System.Guid? parentSpanId)
        {
            this.Name = name;
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.UsageResult = usageResult;
            this.SpanId = spanId;
            this.StartTs = startTs;
            this.EndTs = endTs;
            this.ParentSpanId = parentSpanId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecutionSpan" /> class.
        /// </summary>
        public NodeExecutionSpan()
        {
        }
    }
}