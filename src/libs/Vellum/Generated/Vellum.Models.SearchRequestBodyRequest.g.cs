
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequestBodyRequest
    {
        /// <summary>
        /// The ID of the index to search against. Must provide either this, index_name or document_index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_id")]
        public global::System.Guid? IndexId { get; set; }

        /// <summary>
        /// The name of the index to search against. Must provide either this, index_id or document_index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_name")]
        public string? IndexName { get; set; }

        /// <summary>
        /// The query to search for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Configuration options for the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.SearchRequestOptionsRequest, object>))]
        public global::Vellum.OneOf<global::Vellum.SearchRequestOptionsRequest, object>? Options { get; set; }

        /// <summary>
        /// Either the index name or index ID to search against. Must provide either this, index_id or index_name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_index")]
        public string? DocumentIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestBodyRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// The query to search for.
        /// </param>
        /// <param name="indexId">
        /// The ID of the index to search against. Must provide either this, index_name or document_index.
        /// </param>
        /// <param name="indexName">
        /// The name of the index to search against. Must provide either this, index_id or document_index.
        /// </param>
        /// <param name="options">
        /// Configuration options for the search.
        /// </param>
        /// <param name="documentIndex">
        /// Either the index name or index ID to search against. Must provide either this, index_id or index_name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequestBodyRequest(
            string query,
            global::System.Guid? indexId,
            string? indexName,
            global::Vellum.OneOf<global::Vellum.SearchRequestOptionsRequest, object>? options,
            string? documentIndex)
        {
            this.IndexId = indexId;
            this.IndexName = indexName;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Options = options;
            this.DocumentIndex = documentIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestBodyRequest" /> class.
        /// </summary>
        public SearchRequestBodyRequest()
        {
        }
    }
}