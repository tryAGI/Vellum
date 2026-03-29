
#nullable enable

namespace Vellum
{
    /// <summary>
    /// An audio value for a variable in a Test Case.
    /// </summary>
    public sealed partial class TestCaseAudioVariableValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VariableId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        /// Initializes a new instance of the <see cref="TestCaseAudioVariableValue" /> class.
        /// </summary>
        /// <param name="variableId"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseAudioVariableValue(
            string variableId,
            string name,
            global::Vellum.OneOf<global::Vellum.VellumAudio, object> value,
            global::Vellum.AudioEnum type)
        {
            this.VariableId = variableId ?? throw new global::System.ArgumentNullException(nameof(variableId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseAudioVariableValue" /> class.
        /// </summary>
        public TestCaseAudioVariableValue()
        {
        }
    }
}