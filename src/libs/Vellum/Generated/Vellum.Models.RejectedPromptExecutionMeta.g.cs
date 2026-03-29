
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The subset of the metadata tracked by Vellum during prompt execution that the request opted into with `expand_meta`.
    /// </summary>
    public sealed partial class RejectedPromptExecutionMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public int? Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FinishReasonEnum?, object>))]
        public global::Vellum.OneOf<global::Vellum.FinishReasonEnum?, object>? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectedPromptExecutionMeta" /> class.
        /// </summary>
        /// <param name="latency"></param>
        /// <param name="finishReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RejectedPromptExecutionMeta(
            int? latency,
            global::Vellum.OneOf<global::Vellum.FinishReasonEnum?, object>? finishReason)
        {
            this.Latency = latency;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectedPromptExecutionMeta" /> class.
        /// </summary>
        public RejectedPromptExecutionMeta()
        {
        }
    }
}