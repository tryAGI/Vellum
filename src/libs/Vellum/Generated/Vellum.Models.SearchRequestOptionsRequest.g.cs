
#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchRequestOptionsRequest
    {
        /// <summary>
        /// The maximum number of results to return.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The weights to use for the search. Must add up to 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights")]
        public global::Vellum.SearchWeightsRequest? Weights { get; set; }

        /// <summary>
        /// The configuration for merging results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_merging")]
        public global::Vellum.SearchResultMergingRequest? ResultMerging { get; set; }

        /// <summary>
        /// The filters to apply to the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::Vellum.SearchFiltersRequest? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestOptionsRequest" /> class.
        /// </summary>
        /// <param name="limit">
        /// The maximum number of results to return.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="weights">
        /// The weights to use for the search. Must add up to 1.0.
        /// </param>
        /// <param name="resultMerging">
        /// The configuration for merging results.
        /// </param>
        /// <param name="filters">
        /// The filters to apply to the search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequestOptionsRequest(
            int? limit,
            global::Vellum.SearchWeightsRequest? weights,
            global::Vellum.SearchResultMergingRequest? resultMerging,
            global::Vellum.SearchFiltersRequest? filters)
        {
            this.Limit = limit;
            this.Weights = weights;
            this.ResultMerging = resultMerging;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestOptionsRequest" /> class.
        /// </summary>
        public SearchRequestOptionsRequest()
        {
        }

    }
}