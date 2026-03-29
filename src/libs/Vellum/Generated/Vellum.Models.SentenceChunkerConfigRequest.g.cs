
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Configuration for sentence chunking
    /// </summary>
    public sealed partial class SentenceChunkerConfigRequest
    {
        /// <summary>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_limit")]
        public int? CharacterLimit { get; set; }

        /// <summary>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_overlap_ratio")]
        public double? MinOverlapRatio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentenceChunkerConfigRequest" /> class.
        /// </summary>
        /// <param name="characterLimit">
        /// Default Value: 1000
        /// </param>
        /// <param name="minOverlapRatio">
        /// Default Value: 0.5F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentenceChunkerConfigRequest(
            int? characterLimit,
            double? minOverlapRatio)
        {
            this.CharacterLimit = characterLimit;
            this.MinOverlapRatio = minOverlapRatio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentenceChunkerConfigRequest" /> class.
        /// </summary>
        public SentenceChunkerConfigRequest()
        {
        }
    }
}