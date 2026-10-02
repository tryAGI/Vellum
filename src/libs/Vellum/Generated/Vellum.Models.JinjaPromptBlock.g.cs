
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A block of Jinja template code that is used to generate a prompt
    /// </summary>
    public sealed partial class JinjaPromptBlock
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.JinjaEnumJsonConverter))]
        public global::Vellum.JinjaEnum BlockType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Template { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JinjaPromptBlock" /> class.
        /// </summary>
        /// <param name="template"></param>
        /// <param name="blockType"></param>
        /// <param name="state">
        /// * `ENABLED` - Enabled<br/>
        /// * `DISABLED` - Disabled
        /// </param>
        /// <param name="cacheConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JinjaPromptBlock(
            string template,
            global::Vellum.JinjaEnum blockType,
            global::Vellum.PromptBlockState? state,
            global::Vellum.EphemeralPromptCacheConfig? cacheConfig)
        {
            this.BlockType = blockType;
            this.State = state;
            this.CacheConfig = cacheConfig;
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JinjaPromptBlock" /> class.
        /// </summary>
        public JinjaPromptBlock()
        {
        }

    }
}