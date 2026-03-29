
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The subset of the metadata tracked by Vellum during prompt execution that the request opted into with `expand_meta`.
    /// </summary>
    public sealed partial class StreamingPromptExecutionMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public int? Latency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingPromptExecutionMeta" /> class.
        /// </summary>
        /// <param name="latency"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamingPromptExecutionMeta(
            int? latency)
        {
            this.Latency = latency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingPromptExecutionMeta" /> class.
        /// </summary>
        public StreamingPromptExecutionMeta()
        {
        }
    }
}