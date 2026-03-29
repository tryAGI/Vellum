
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A value representing Search Results.
    /// </summary>
    public sealed partial class ExecutionSearchResultsVellumValue
    {
        /// <summary>
        /// The variable's uniquely identifying internal id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        public global::System.Collections.Generic.IList<global::Vellum.SearchResult>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionSearchResultsVellumValue" /> class.
        /// </summary>
        /// <param name="id">
        /// The variable's uniquely identifying internal id.
        /// </param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutionSearchResultsVellumValue(
            string id,
            string name,
            global::Vellum.SearchResultsEnum type,
            global::System.Collections.Generic.IList<global::Vellum.SearchResult>? value)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionSearchResultsVellumValue" /> class.
        /// </summary>
        public ExecutionSearchResultsVellumValue()
        {
        }
    }
}