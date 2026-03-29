
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A value representing Chat History.
    /// </summary>
    public sealed partial class ChatHistoryVellumValue
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatHistoryVellumValue" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatHistoryVellumValue(
            global::Vellum.ChatHistoryEnum type,
            global::System.Collections.Generic.IList<global::Vellum.ChatMessage>? value)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatHistoryVellumValue" /> class.
        /// </summary>
        public ChatHistoryVellumValue()
        {
        }
    }
}