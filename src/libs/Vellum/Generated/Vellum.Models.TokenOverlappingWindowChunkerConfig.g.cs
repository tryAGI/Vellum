
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Configuration for token overlapping window chunking
    /// </summary>
    public sealed partial class TokenOverlappingWindowChunkerConfig
    {
        /// <summary>
        /// Default Value: 250
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_limit")]
        public int? TokenLimit { get; set; }

        /// <summary>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlap_ratio")]
        public double? OverlapRatio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenOverlappingWindowChunkerConfig" /> class.
        /// </summary>
        /// <param name="tokenLimit">
        /// Default Value: 250
        /// </param>
        /// <param name="overlapRatio">
        /// Default Value: 0.5F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenOverlappingWindowChunkerConfig(
            int? tokenLimit,
            double? overlapRatio)
        {
            this.TokenLimit = tokenLimit;
            this.OverlapRatio = overlapRatio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenOverlappingWindowChunkerConfig" /> class.
        /// </summary>
        public TokenOverlappingWindowChunkerConfig()
        {
        }
    }
}