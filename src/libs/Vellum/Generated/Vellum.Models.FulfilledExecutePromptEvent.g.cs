
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The final data event returned indicating that the stream has ended and all final resolved values from the model can be found.
    /// </summary>
    public sealed partial class FulfilledExecutePromptEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.FulfilledEnumJsonConverter))]
        public global::Vellum.FulfilledEnum State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.PromptOutput> Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionId { get; set; }

        /// <summary>
        /// The subset of the metadata tracked by Vellum during prompt execution that the request opted into with `expand_meta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::Vellum.FulfilledPromptExecutionMeta? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_message_metadata")]
        public object? ChatMessageMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfilledExecutePromptEvent" /> class.
        /// </summary>
        /// <param name="outputs"></param>
        /// <param name="executionId"></param>
        /// <param name="state"></param>
        /// <param name="meta">
        /// The subset of the metadata tracked by Vellum during prompt execution that the request opted into with `expand_meta`.
        /// </param>
        /// <param name="chatMessageMetadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FulfilledExecutePromptEvent(
            global::System.Collections.Generic.IList<global::Vellum.PromptOutput> outputs,
            string executionId,
            global::Vellum.FulfilledEnum state,
            global::Vellum.FulfilledPromptExecutionMeta? meta,
            object? chatMessageMetadata)
        {
            this.State = state;
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
            this.Meta = meta;
            this.ChatMessageMetadata = chatMessageMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfilledExecutePromptEvent" /> class.
        /// </summary>
        public FulfilledExecutePromptEvent()
        {
        }
    }
}