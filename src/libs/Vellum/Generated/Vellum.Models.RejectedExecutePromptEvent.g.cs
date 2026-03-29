
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The final data returned indicating an error occurred during the stream.
    /// </summary>
    public sealed partial class RejectedExecutePromptEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.RejectedEnumJsonConverter))]
        public global::Vellum.RejectedEnum State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumError Error { get; set; }

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
        public global::Vellum.RejectedPromptExecutionMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectedExecutePromptEvent" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="executionId"></param>
        /// <param name="state"></param>
        /// <param name="meta">
        /// The subset of the metadata tracked by Vellum during prompt execution that the request opted into with `expand_meta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RejectedExecutePromptEvent(
            global::Vellum.VellumError error,
            string executionId,
            global::Vellum.RejectedEnum state,
            global::Vellum.RejectedPromptExecutionMeta? meta)
        {
            this.State = state;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectedExecutePromptEvent" /> class.
        /// </summary>
        public RejectedExecutePromptEvent()
        {
        }
    }
}