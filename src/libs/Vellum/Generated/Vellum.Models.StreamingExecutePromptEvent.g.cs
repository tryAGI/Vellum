
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The data returned for each delta during the prompt execution stream.
    /// </summary>
    public sealed partial class StreamingExecutePromptEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.StreamingEnumJsonConverter))]
        public global::Vellum.StreamingEnum State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.PromptOutputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.PromptOutput Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

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
        public global::Vellum.StreamingPromptExecutionMeta? Meta { get; set; }

        /// <summary>
        /// The subset of the raw response from the model that the request opted into with `expand_raw`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        public object? Raw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingExecutePromptEvent" /> class.
        /// </summary>
        /// <param name="output"></param>
        /// <param name="outputIndex"></param>
        /// <param name="executionId"></param>
        /// <param name="state"></param>
        /// <param name="meta">
        /// The subset of the metadata tracked by Vellum during prompt execution that the request opted into with `expand_meta`.
        /// </param>
        /// <param name="raw">
        /// The subset of the raw response from the model that the request opted into with `expand_raw`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamingExecutePromptEvent(
            global::Vellum.PromptOutput output,
            int outputIndex,
            string executionId,
            global::Vellum.StreamingEnum state,
            global::Vellum.StreamingPromptExecutionMeta? meta,
            object? raw)
        {
            this.State = state;
            this.Output = output;
            this.OutputIndex = outputIndex;
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
            this.Meta = meta;
            this.Raw = raw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingExecutePromptEvent" /> class.
        /// </summary>
        public StreamingExecutePromptEvent()
        {
        }
    }
}