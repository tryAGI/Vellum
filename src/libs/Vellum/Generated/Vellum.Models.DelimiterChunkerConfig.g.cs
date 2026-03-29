
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DelimiterChunkerConfig
    {
        /// <summary>
        /// Default Value: \n\n
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delimiter")]
        public string? Delimiter { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_regex")]
        public bool? IsRegex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DelimiterChunkerConfig" /> class.
        /// </summary>
        /// <param name="delimiter">
        /// Default Value: \n\n
        /// </param>
        /// <param name="isRegex">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DelimiterChunkerConfig(
            string? delimiter,
            bool? isRegex)
        {
            this.Delimiter = delimiter;
            this.IsRegex = isRegex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelimiterChunkerConfig" /> class.
        /// </summary>
        public DelimiterChunkerConfig()
        {
        }
    }
}