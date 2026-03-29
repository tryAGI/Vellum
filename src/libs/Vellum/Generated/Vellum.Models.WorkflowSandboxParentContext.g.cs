
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowSandboxParentContext
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.WorkflowSandboxEnumJsonConverter))]
        public global::Vellum.WorkflowSandboxEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SandboxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_history_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SandboxHistoryItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenario_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ScenarioId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowSandboxParentContext" /> class.
        /// </summary>
        /// <param name="spanId"></param>
        /// <param name="sandboxId"></param>
        /// <param name="sandboxHistoryItemId"></param>
        /// <param name="scenarioId"></param>
        /// <param name="parent"></param>
        /// <param name="links"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowSandboxParentContext(
            global::System.Guid spanId,
            global::System.Guid sandboxId,
            global::System.Guid sandboxHistoryItemId,
            global::System.Guid scenarioId,
            global::Vellum.OneOf<global::Vellum.ParentContext?, object>? parent,
            global::System.Collections.Generic.IList<global::Vellum.SpanLink>? links,
            global::Vellum.WorkflowSandboxEnum type)
        {
            this.Parent = parent;
            this.Links = links;
            this.Type = type;
            this.SpanId = spanId;
            this.SandboxId = sandboxId;
            this.SandboxHistoryItemId = sandboxHistoryItemId;
            this.ScenarioId = scenarioId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowSandboxParentContext" /> class.
        /// </summary>
        public WorkflowSandboxParentContext()
        {
        }
    }
}