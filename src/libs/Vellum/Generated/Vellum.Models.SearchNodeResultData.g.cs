
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchNodeResultData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results_output_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResultsOutputId { get; set; }

        /// <summary>
        /// The results of the search. Each result represents a chunk that matches the search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.SearchResult> Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_output_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextOutputId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchNodeResultData" /> class.
        /// </summary>
        /// <param name="resultsOutputId"></param>
        /// <param name="results">
        /// The results of the search. Each result represents a chunk that matches the search query.
        /// </param>
        /// <param name="textOutputId"></param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchNodeResultData(
            string resultsOutputId,
            global::System.Collections.Generic.IList<global::Vellum.SearchResult> results,
            string textOutputId,
            string? text)
        {
            this.ResultsOutputId = resultsOutputId ?? throw new global::System.ArgumentNullException(nameof(resultsOutputId));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.TextOutputId = textOutputId ?? throw new global::System.ArgumentNullException(nameof(textOutputId));
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchNodeResultData" /> class.
        /// </summary>
        public SearchNodeResultData()
        {
        }
    }
}