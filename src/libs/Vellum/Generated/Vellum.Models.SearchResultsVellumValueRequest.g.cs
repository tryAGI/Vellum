
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A value representing Search Results.
    /// </summary>
    public sealed partial class SearchResultsVellumValueRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.SearchResultsEnumJsonConverter))]
        public global::Vellum.SearchResultsEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::System.Collections.Generic.IList<global::Vellum.SearchResultRequest>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultsVellumValueRequest" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultsVellumValueRequest(
            global::Vellum.SearchResultsEnum type,
            global::System.Collections.Generic.IList<global::Vellum.SearchResultRequest>? value)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultsVellumValueRequest" /> class.
        /// </summary>
        public SearchResultsVellumValueRequest()
        {
        }
    }
}