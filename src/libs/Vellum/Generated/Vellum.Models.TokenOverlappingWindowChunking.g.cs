
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Token overlapping window chunking
    /// </summary>
    public sealed partial class TokenOverlappingWindowChunking
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunker_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.TokenOverlappingWindowChunkerEnumJsonConverter))]
        public global::Vellum.TokenOverlappingWindowChunkerEnum ChunkerName { get; set; }

        /// <summary>
        /// Configuration for token overlapping window chunking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunker_config")]
        public global::Vellum.TokenOverlappingWindowChunkerConfig? ChunkerConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenOverlappingWindowChunking" /> class.
        /// </summary>
        /// <param name="chunkerName"></param>
        /// <param name="chunkerConfig">
        /// Configuration for token overlapping window chunking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenOverlappingWindowChunking(
            global::Vellum.TokenOverlappingWindowChunkerEnum chunkerName,
            global::Vellum.TokenOverlappingWindowChunkerConfig? chunkerConfig)
        {
            this.ChunkerName = chunkerName;
            this.ChunkerConfig = chunkerConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenOverlappingWindowChunking" /> class.
        /// </summary>
        public TokenOverlappingWindowChunking()
        {
        }
    }
}