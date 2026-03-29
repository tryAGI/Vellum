
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Reducto chunking
    /// </summary>
    public sealed partial class ReductoChunking
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunker_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ReductoChunkerEnumJsonConverter))]
        public global::Vellum.ReductoChunkerEnum ChunkerName { get; set; }

        /// <summary>
        /// Configuration for Reducto chunking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunker_config")]
        public global::Vellum.ReductoChunkerConfig? ChunkerConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReductoChunking" /> class.
        /// </summary>
        /// <param name="chunkerName"></param>
        /// <param name="chunkerConfig">
        /// Configuration for Reducto chunking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReductoChunking(
            global::Vellum.ReductoChunkerEnum chunkerName,
            global::Vellum.ReductoChunkerConfig? chunkerConfig)
        {
            this.ChunkerName = chunkerName;
            this.ChunkerConfig = chunkerConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReductoChunking" /> class.
        /// </summary>
        public ReductoChunking()
        {
        }
    }
}