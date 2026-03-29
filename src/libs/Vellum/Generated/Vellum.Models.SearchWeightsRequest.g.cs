
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchWeightsRequest
    {
        /// <summary>
        /// The relative weight to give to semantic similarity<br/>
        /// Default Value: 0.8F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("semantic_similarity")]
        public double? SemanticSimilarity { get; set; }

        /// <summary>
        /// The relative weight to give to keywords<br/>
        /// Default Value: 0.2F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public double? Keywords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWeightsRequest" /> class.
        /// </summary>
        /// <param name="semanticSimilarity">
        /// The relative weight to give to semantic similarity<br/>
        /// Default Value: 0.8F
        /// </param>
        /// <param name="keywords">
        /// The relative weight to give to keywords<br/>
        /// Default Value: 0.2F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchWeightsRequest(
            double? semanticSimilarity,
            double? keywords)
        {
            this.SemanticSimilarity = semanticSimilarity;
            this.Keywords = keywords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWeightsRequest" /> class.
        /// </summary>
        public SearchWeightsRequest()
        {
        }
    }
}