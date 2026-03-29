
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DelimiterChunking
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunker_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.DelimiterChunkerEnumJsonConverter))]
        public global::Vellum.DelimiterChunkerEnum ChunkerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunker_config")]
        public global::Vellum.DelimiterChunkerConfig? ChunkerConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DelimiterChunking" /> class.
        /// </summary>
        /// <param name="chunkerName"></param>
        /// <param name="chunkerConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DelimiterChunking(
            global::Vellum.DelimiterChunkerEnum chunkerName,
            global::Vellum.DelimiterChunkerConfig? chunkerConfig)
        {
            this.ChunkerName = chunkerName;
            this.ChunkerConfig = chunkerConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelimiterChunking" /> class.
        /// </summary>
        public DelimiterChunking()
        {
        }
    }
}