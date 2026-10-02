
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A block that represents a chat message in a prompt template.
    /// </summary>
    public sealed partial class ChatMessagePromptBlock
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ChatMessageEnumJsonConverter))]
        public global::Vellum.ChatMessageEnum BlockType { get; set; }

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
        /// * `SYSTEM` - System<br/>
        /// * `ASSISTANT` - Assistant<br/>
        /// * `USER` - User<br/>
        /// * `FUNCTION` - Function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ChatMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.ChatMessageRole ChatRole { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_source")]
        public string? ChatSource { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_message_unterminated")]
        public bool? ChatMessageUnterminated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.PromptBlock> Blocks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessagePromptBlock" /> class.
        /// </summary>
        /// <param name="chatRole">
        /// * `SYSTEM` - System<br/>
        /// * `ASSISTANT` - Assistant<br/>
        /// * `USER` - User<br/>
        /// * `FUNCTION` - Function
        /// </param>
        /// <param name="blocks"></param>
        /// <param name="blockType"></param>
        /// <param name="state">
        /// * `ENABLED` - Enabled<br/>
        /// * `DISABLED` - Disabled
        /// </param>
        /// <param name="cacheConfig"></param>
        /// <param name="chatSource"></param>
        /// <param name="chatMessageUnterminated">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMessagePromptBlock(
            global::Vellum.ChatMessageRole chatRole,
            global::System.Collections.Generic.IList<global::Vellum.PromptBlock> blocks,
            global::Vellum.ChatMessageEnum blockType,
            global::Vellum.PromptBlockState? state,
            global::Vellum.EphemeralPromptCacheConfig? cacheConfig,
            string? chatSource,
            bool? chatMessageUnterminated)
        {
            this.BlockType = blockType;
            this.State = state;
            this.CacheConfig = cacheConfig;
            this.ChatRole = chatRole;
            this.ChatSource = chatSource;
            this.ChatMessageUnterminated = chatMessageUnterminated;
            this.Blocks = blocks ?? throw new global::System.ArgumentNullException(nameof(blocks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessagePromptBlock" /> class.
        /// </summary>
        public ChatMessagePromptBlock()
        {
        }

    }
}