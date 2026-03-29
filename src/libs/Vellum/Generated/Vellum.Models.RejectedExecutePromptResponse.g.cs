
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The unsuccessful response from the model containing an error of what went wrong.
    /// </summary>
    public sealed partial class RejectedExecutePromptResponse
    {
        /// <summary>
        /// The subset of the metadata tracked by Vellum during prompt execution that the request opted into with `expand_meta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::Vellum.PromptExecutionMeta? Meta { get; set; }

        /// <summary>
        /// The subset of the raw response from the model that the request opted into with `expand_raw`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        public object? Raw { get; set; }

        /// <summary>
        /// The ID of the execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectedExecutePromptResponse" /> class.
        /// </summary>
        /// <param name="executionId">
        /// The ID of the execution.
        /// </param>
        /// <param name="error"></param>
        /// <param name="meta">
        /// The subset of the metadata tracked by Vellum during prompt execution that the request opted into with `expand_meta`.
        /// </param>
        /// <param name="raw">
        /// The subset of the raw response from the model that the request opted into with `expand_raw`.
        /// </param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RejectedExecutePromptResponse(
            string executionId,
            global::Vellum.VellumError error,
            global::Vellum.PromptExecutionMeta? meta,
            object? raw,
            global::Vellum.RejectedEnum state)
        {
            this.Meta = meta;
            this.Raw = raw;
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
            this.State = state;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectedExecutePromptResponse" /> class.
        /// </summary>
        public RejectedExecutePromptResponse()
        {
        }
    }
}