
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeParentContext
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
        [global::System.Text.Json.Serialization.JsonPropertyName("node_definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumCodeResourceDefinition NodeDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.WorkflowNodeEnumJsonConverter))]
        public global::Vellum.WorkflowNodeEnum Type { get; set; }

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
        /// Initializes a new instance of the <see cref="NodeParentContext" /> class.
        /// </summary>
        /// <param name="nodeDefinition"></param>
        /// <param name="spanId"></param>
        /// <param name="parent"></param>
        /// <param name="links"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeParentContext(
            global::Vellum.VellumCodeResourceDefinition nodeDefinition,
            global::System.Guid spanId,
            global::Vellum.OneOf<global::Vellum.ParentContext?, object>? parent,
            global::System.Collections.Generic.IList<global::Vellum.SpanLink>? links,
            global::Vellum.WorkflowNodeEnum type)
        {
            this.Parent = parent;
            this.Links = links;
            this.NodeDefinition = nodeDefinition ?? throw new global::System.ArgumentNullException(nameof(nodeDefinition));
            this.Type = type;
            this.SpanId = spanId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeParentContext" /> class.
        /// </summary>
        public NodeParentContext()
        {
        }
    }
}