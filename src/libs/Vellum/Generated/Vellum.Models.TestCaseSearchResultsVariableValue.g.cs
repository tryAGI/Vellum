
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A search results value for a variable in a Test Case.
    /// </summary>
    public sealed partial class TestCaseSearchResultsVariableValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VariableId { get; set; }

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
        /// Initializes a new instance of the <see cref="TestCaseSearchResultsVariableValue" /> class.
        /// </summary>
        /// <param name="variableId"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseSearchResultsVariableValue(
            string variableId,
            string name,
            global::Vellum.SearchResultsEnum type,
            global::System.Collections.Generic.IList<global::Vellum.SearchResult>? value)
        {
            this.VariableId = variableId ?? throw new global::System.ArgumentNullException(nameof(variableId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseSearchResultsVariableValue" /> class.
        /// </summary>
        public TestCaseSearchResultsVariableValue()
        {
        }
    }
}