
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A block that represents a function call in a prompt template.
    /// </summary>
    public sealed partial class FunctionCallPromptBlock
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.FunctionCallEnumJsonConverter))]
        public global::Vellum.FunctionCallEnum BlockType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallPromptBlock" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        /// <param name="blockType"></param>
        /// <param name="state">
        /// * `ENABLED` - Enabled<br/>
        /// * `DISABLED` - Disabled
        /// </param>
        /// <param name="cacheConfig"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallPromptBlock(
            string name,
            object arguments,
            global::Vellum.FunctionCallEnum blockType,
            global::Vellum.PromptBlockState? state,
            global::Vellum.EphemeralPromptCacheConfig? cacheConfig,
            string? id)
        {
            this.BlockType = blockType;
            this.State = state;
            this.CacheConfig = cacheConfig;
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallPromptBlock" /> class.
        /// </summary>
        public FunctionCallPromptBlock()
        {
        }

    }
}