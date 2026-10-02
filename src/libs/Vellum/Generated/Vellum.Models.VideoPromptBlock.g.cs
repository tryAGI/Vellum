
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A block that represents an video file in a prompt template.
    /// </summary>
    public sealed partial class VideoPromptBlock
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.VideoEnumJsonConverter))]
        public global::Vellum.VideoEnum BlockType { get; set; }

        /// <summary>
        /// * `ENABLED` - Enabled<br/>
        /// * `DISABLED` - Disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.PromptBlockStateJsonConverter))]
        public global::Vellum.PromptBlockState? State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_config")]
        public global::Vellum.EphemeralPromptCacheConfig? CacheConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoPromptBlock" /> class.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="blockType"></param>
        /// <param name="state">
        /// * `ENABLED` - Enabled<br/>
        /// * `DISABLED` - Disabled
        /// </param>
        /// <param name="cacheConfig"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoPromptBlock(
            string src,
            global::Vellum.VideoEnum blockType,
            global::Vellum.PromptBlockState? state,
            global::Vellum.EphemeralPromptCacheConfig? cacheConfig,
            object? metadata)
        {
            this.BlockType = blockType;
            this.State = state;
            this.CacheConfig = cacheConfig;
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoPromptBlock" /> class.
        /// </summary>
        public VideoPromptBlock()
        {
        }

    }
}