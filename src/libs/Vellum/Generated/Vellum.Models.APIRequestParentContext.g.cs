
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIRequestParentContext
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ApiRequestEnumJsonConverter))]
        public global::Vellum.ApiRequestEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_actor_id")]
        public string? ApiActorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_actor_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ApiActorTypeEnum?, object>))]
        public global::Vellum.OneOf<global::Vellum.ApiActorTypeEnum?, object>? ApiActorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_actor_label")]
        public string? ApiActorLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIRequestParentContext" /> class.
        /// </summary>
        /// <param name="spanId"></param>
        /// <param name="parent"></param>
        /// <param name="links"></param>
        /// <param name="type"></param>
        /// <param name="apiActorId"></param>
        /// <param name="apiActorType"></param>
        /// <param name="apiActorLabel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public APIRequestParentContext(
            global::System.Guid spanId,
            global::Vellum.OneOf<global::Vellum.ParentContext?, object>? parent,
            global::System.Collections.Generic.IList<global::Vellum.SpanLink>? links,
            global::Vellum.ApiRequestEnum type,
            string? apiActorId,
            global::Vellum.OneOf<global::Vellum.ApiActorTypeEnum?, object>? apiActorType,
            string? apiActorLabel)
        {
            this.Parent = parent;
            this.Links = links;
            this.Type = type;
            this.SpanId = spanId;
            this.ApiActorId = apiActorId;
            this.ApiActorType = apiActorType;
            this.ApiActorLabel = apiActorLabel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIRequestParentContext" /> class.
        /// </summary>
        public APIRequestParentContext()
        {
        }
    }
}