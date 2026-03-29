
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeInputCompiledAudioValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_input_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeInputId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.AudioEnumJsonConverter))]
        public global::Vellum.AudioEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumAudio, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.OneOf<global::Vellum.VellumAudio, object> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInputCompiledAudioValue" /> class.
        /// </summary>
        /// <param name="nodeInputId"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeInputCompiledAudioValue(
            string nodeInputId,
            string key,
            global::Vellum.OneOf<global::Vellum.VellumAudio, object> value,
            global::Vellum.AudioEnum type)
        {
            this.NodeInputId = nodeInputId ?? throw new global::System.ArgumentNullException(nameof(nodeInputId));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInputCompiledAudioValue" /> class.
        /// </summary>
        public NodeInputCompiledAudioValue()
        {
        }
    }
}