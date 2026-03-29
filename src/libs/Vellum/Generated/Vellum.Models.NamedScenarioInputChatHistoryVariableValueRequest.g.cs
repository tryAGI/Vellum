
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Named Prompt Sandbox Scenario input value that is of type CHAT_HISTORY
    /// </summary>
    public sealed partial class NamedScenarioInputChatHistoryVariableValueRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ChatHistoryEnumJsonConverter))]
        public global::Vellum.ChatHistoryEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::System.Collections.Generic.IList<global::Vellum.ChatMessageRequest>? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedScenarioInputChatHistoryVariableValueRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamedScenarioInputChatHistoryVariableValueRequest(
            string name,
            global::Vellum.ChatHistoryEnum type,
            global::System.Collections.Generic.IList<global::Vellum.ChatMessageRequest>? value)
        {
            this.Type = type;
            this.Value = value;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedScenarioInputChatHistoryVariableValueRequest" /> class.
        /// </summary>
        public NamedScenarioInputChatHistoryVariableValueRequest()
        {
        }
    }
}