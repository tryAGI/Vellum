
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Prompt Sandbox Scenario input value that is of type CHAT_HISTORY
    /// </summary>
    public sealed partial class ScenarioInputChatHistoryVariableValue
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
        public global::System.Collections.Generic.IList<global::Vellum.ChatMessage>? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_variable_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputVariableId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioInputChatHistoryVariableValue" /> class.
        /// </summary>
        /// <param name="inputVariableId"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScenarioInputChatHistoryVariableValue(
            string inputVariableId,
            global::Vellum.ChatHistoryEnum type,
            global::System.Collections.Generic.IList<global::Vellum.ChatMessage>? value)
        {
            this.Type = type;
            this.Value = value;
            this.InputVariableId = inputVariableId ?? throw new global::System.ArgumentNullException(nameof(inputVariableId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioInputChatHistoryVariableValue" /> class.
        /// </summary>
        public ScenarioInputChatHistoryVariableValue()
        {
        }
    }
}