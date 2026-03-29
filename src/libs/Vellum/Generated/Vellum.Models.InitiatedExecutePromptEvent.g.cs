
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The initial data returned indicating that the response from the model has returned and begun streaming.
    /// </summary>
    public sealed partial class InitiatedExecutePromptEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.InitiatedEnumJsonConverter))]
        public global::Vellum.InitiatedEnum State { get; set; }

        /// <summary>
        /// The subset of the metadata tracked by Vellum during prompt execution that the request opted into with `expand_meta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::Vellum.InitiatedPromptExecutionMeta? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitiatedExecutePromptEvent" /> class.
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="state"></param>
        /// <param name="meta">
        /// The subset of the metadata tracked by Vellum during prompt execution that the request opted into with `expand_meta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InitiatedExecutePromptEvent(
            string executionId,
            global::Vellum.InitiatedEnum state,
            global::Vellum.InitiatedPromptExecutionMeta? meta)
        {
            this.State = state;
            this.Meta = meta;
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitiatedExecutePromptEvent" /> class.
        /// </summary>
        public InitiatedExecutePromptEvent()
        {
        }
    }
}