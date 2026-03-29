
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A function call value that is used in a chat message.
    /// </summary>
    public sealed partial class FunctionCallChatMessageContentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.FunctionCallEnumJsonConverter))]
        public global::Vellum.FunctionCallEnum Type { get; set; }

        /// <summary>
        /// The final resolved function call value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.FunctionCallChatMessageContentValueRequest Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallChatMessageContentRequest" /> class.
        /// </summary>
        /// <param name="value">
        /// The final resolved function call value.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallChatMessageContentRequest(
            global::Vellum.FunctionCallChatMessageContentValueRequest value,
            global::Vellum.FunctionCallEnum type)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallChatMessageContentRequest" /> class.
        /// </summary>
        public FunctionCallChatMessageContentRequest()
        {
        }
    }
}