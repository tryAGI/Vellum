
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeExecutionStreamingEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>))]
        public global::Vellum.OneOf<global::Vellum.ParentContext?, object>? Parent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::System.Collections.Generic.IList<global::Vellum.SpanLink>? Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.NodeExecutionStreamingEnumJsonConverter))]
        public global::Vellum.NodeExecutionStreamingEnum Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.NodeExecutionStreamingBody Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// * `2024-10-25` - V2024_10_25<br/>
        /// * `2025-07-30` - V2025_07_30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ApiVersionEnumJsonConverter))]
        public global::Vellum.ApiVersionEnum? ApiVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SpanId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecutionStreamingEvent" /> class.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id"></param>
        /// <param name="timestamp"></param>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="parent"></param>
        /// <param name="links"></param>
        /// <param name="name"></param>
        /// <param name="apiVersion">
        /// * `2024-10-25` - V2024_10_25<br/>
        /// * `2025-07-30` - V2025_07_30
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeExecutionStreamingEvent(
            global::Vellum.NodeExecutionStreamingBody body,
            global::System.Guid id,
            global::System.DateTime timestamp,
            global::System.Guid traceId,
            global::System.Guid spanId,
            global::Vellum.OneOf<global::Vellum.ParentContext?, object>? parent,
            global::System.Collections.Generic.IList<global::Vellum.SpanLink>? links,
            global::Vellum.NodeExecutionStreamingEnum name,
            global::Vellum.ApiVersionEnum? apiVersion)
        {
            this.Parent = parent;
            this.Links = links;
            this.Name = name;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.Id = id;
            this.Timestamp = timestamp;
            this.ApiVersion = apiVersion;
            this.TraceId = traceId;
            this.SpanId = spanId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecutionStreamingEvent" /> class.
        /// </summary>
        public NodeExecutionStreamingEvent()
        {
        }
    }
}