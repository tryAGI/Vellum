
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MLModelUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_token_count")]
        public int? OutputTokenCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_token_count")]
        public int? InputTokenCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_char_count")]
        public int? InputCharCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_char_count")]
        public int? OutputCharCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_nanos")]
        public int? ComputeNanos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        public int? CacheCreationInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MLModelUsage" /> class.
        /// </summary>
        /// <param name="outputTokenCount"></param>
        /// <param name="inputTokenCount"></param>
        /// <param name="inputCharCount"></param>
        /// <param name="outputCharCount"></param>
        /// <param name="computeNanos"></param>
        /// <param name="cacheCreationInputTokens"></param>
        /// <param name="cacheReadInputTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MLModelUsage(
            int? outputTokenCount,
            int? inputTokenCount,
            int? inputCharCount,
            int? outputCharCount,
            int? computeNanos,
            int? cacheCreationInputTokens,
            int? cacheReadInputTokens)
        {
            this.OutputTokenCount = outputTokenCount;
            this.InputTokenCount = inputTokenCount;
            this.InputCharCount = inputCharCount;
            this.OutputCharCount = outputCharCount;
            this.ComputeNanos = computeNanos;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MLModelUsage" /> class.
        /// </summary>
        public MLModelUsage()
        {
        }
    }
}