
#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchResultMetaRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::Vellum.SearchResultMetaSourceRequest? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultMetaRequest" /> class.
        /// </summary>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultMetaRequest(
            global::Vellum.SearchResultMetaSourceRequest? source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultMetaRequest" /> class.
        /// </summary>
        public SearchResultMetaRequest()
        {
        }

    }
}