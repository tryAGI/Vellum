
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowParentContext
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
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumCodeResourceDefinition WorkflowDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.WorkflowEnumJsonConverter))]
        public global::Vellum.WorkflowEnum Type { get; set; }

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
        /// Initializes a new instance of the <see cref="WorkflowParentContext" /> class.
        /// </summary>
        /// <param name="workflowDefinition"></param>
        /// <param name="spanId"></param>
        /// <param name="parent"></param>
        /// <param name="links"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowParentContext(
            global::Vellum.VellumCodeResourceDefinition workflowDefinition,
            global::System.Guid spanId,
            global::Vellum.OneOf<global::Vellum.ParentContext?, object>? parent,
            global::System.Collections.Generic.IList<global::Vellum.SpanLink>? links,
            global::Vellum.WorkflowEnum type)
        {
            this.Parent = parent;
            this.Links = links;
            this.WorkflowDefinition = workflowDefinition ?? throw new global::System.ArgumentNullException(nameof(workflowDefinition));
            this.Type = type;
            this.SpanId = spanId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowParentContext" /> class.
        /// </summary>
        public WorkflowParentContext()
        {
        }
    }
}