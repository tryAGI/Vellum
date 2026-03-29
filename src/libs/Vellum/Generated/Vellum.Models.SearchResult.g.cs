
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResult
    {
        /// <summary>
        /// The text of the chunk that matched the search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// A score representing how well the chunk matches the search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Keywords { get; set; }

        /// <summary>
        /// The document that contains the chunk that matched the search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.SearchResultDocument Document { get; set; }

        /// <summary>
        /// Additional information about the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.SearchResultMeta, object>))]
        public global::Vellum.OneOf<global::Vellum.SearchResultMeta, object>? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult" /> class.
        /// </summary>
        /// <param name="text">
        /// The text of the chunk that matched the search query.
        /// </param>
        /// <param name="score">
        /// A score representing how well the chunk matches the search query.
        /// </param>
        /// <param name="keywords"></param>
        /// <param name="document">
        /// The document that contains the chunk that matched the search query.
        /// </param>
        /// <param name="meta">
        /// Additional information about the search result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResult(
            string text,
            double score,
            global::System.Collections.Generic.IList<string> keywords,
            global::Vellum.SearchResultDocument document,
            global::Vellum.OneOf<global::Vellum.SearchResultMeta, object>? meta)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Score = score;
            this.Keywords = keywords ?? throw new global::System.ArgumentNullException(nameof(keywords));
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult" /> class.
        /// </summary>
        public SearchResult()
        {
        }
    }
}