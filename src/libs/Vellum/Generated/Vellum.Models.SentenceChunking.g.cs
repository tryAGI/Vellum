
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Sentence chunking
    /// </summary>
    public sealed partial class SentenceChunking
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunker_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.SentenceChunkerEnumJsonConverter))]
        public global::Vellum.SentenceChunkerEnum ChunkerName { get; set; }

        /// <summary>
        /// Configuration for sentence chunking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunker_config")]
        public global::Vellum.SentenceChunkerConfig? ChunkerConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentenceChunking" /> class.
        /// </summary>
        /// <param name="chunkerName"></param>
        /// <param name="chunkerConfig">
        /// Configuration for sentence chunking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentenceChunking(
            global::Vellum.SentenceChunkerEnum chunkerName,
            global::Vellum.SentenceChunkerConfig? chunkerConfig)
        {
            this.ChunkerName = chunkerName;
            this.ChunkerConfig = chunkerConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentenceChunking" /> class.
        /// </summary>
        public SentenceChunking()
        {
        }
    }
}