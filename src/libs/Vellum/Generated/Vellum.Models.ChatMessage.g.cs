
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// * `SYSTEM` - System<br/>
        /// * `ASSISTANT` - Assistant<br/>
        /// * `USER` - User<br/>
        /// * `FUNCTION` - Function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ChatMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.ChatMessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ChatMessageContent?, object>))]
        public global::Vellum.OneOf<global::Vellum.ChatMessageContent?, object>? Content { get; set; }

        /// <summary>
        /// An optional identifier representing who or what generated this message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// * `SYSTEM` - System<br/>
        /// * `ASSISTANT` - Assistant<br/>
        /// * `USER` - User<br/>
        /// * `FUNCTION` - Function
        /// </param>
        /// <param name="text"></param>
        /// <param name="content"></param>
        /// <param name="source">
        /// An optional identifier representing who or what generated this message.
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMessage(
            global::Vellum.ChatMessageRole role,
            string? text,
            global::Vellum.OneOf<global::Vellum.ChatMessageContent?, object>? content,
            string? source,
            object? metadata)
        {
            this.Text = text;
            this.Role = role;
            this.Content = content;
            this.Source = source;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        public ChatMessage()
        {
        }
    }
}