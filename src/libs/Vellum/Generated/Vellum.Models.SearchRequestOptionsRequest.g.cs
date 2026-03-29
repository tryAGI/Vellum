
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.SearchWeightsRequest, object>))]
        public global::Vellum.OneOf<global::Vellum.SearchWeightsRequest, object>? Weights { get; set; }

        /// <summary>
        /// The configuration for merging results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_merging")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.SearchResultMergingRequest, object>))]
        public global::Vellum.OneOf<global::Vellum.SearchResultMergingRequest, object>? ResultMerging { get; set; }

        /// <summary>
        /// The filters to apply to the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.SearchFiltersRequest, object>))]
        public global::Vellum.OneOf<global::Vellum.SearchFiltersRequest, object>? Filters { get; set; }

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
            global::Vellum.OneOf<global::Vellum.SearchWeightsRequest, object>? weights,
            global::Vellum.OneOf<global::Vellum.SearchResultMergingRequest, object>? resultMerging,
            global::Vellum.OneOf<global::Vellum.SearchFiltersRequest, object>? filters)
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