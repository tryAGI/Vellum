
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanLink
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TraceId { get; set; }

        /// <summary>
        /// * `TRIGGERED_BY` - TRIGGERED_BY<br/>
        /// * `PREVIOUS_SPAN` - PREVIOUS_SPAN<br/>
        /// * `ROOT_SPAN` - ROOT_SPAN
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.SpanLinkTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.SpanLinkTypeEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ParentContextJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.ParentContext SpanContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanLink" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="type">
        /// * `TRIGGERED_BY` - TRIGGERED_BY<br/>
        /// * `PREVIOUS_SPAN` - PREVIOUS_SPAN<br/>
        /// * `ROOT_SPAN` - ROOT_SPAN
        /// </param>
        /// <param name="spanContext"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpanLink(
            global::System.Guid traceId,
            global::Vellum.SpanLinkTypeEnum type,
            global::Vellum.ParentContext spanContext)
        {
            this.TraceId = traceId;
            this.Type = type;
            this.SpanContext = spanContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanLink" /> class.
        /// </summary>
        public SpanLink()
        {
        }
    }
}