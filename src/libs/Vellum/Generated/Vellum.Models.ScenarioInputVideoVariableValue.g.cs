
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScenarioInputVideoVariableValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.VideoEnumJsonConverter))]
        public global::Vellum.VideoEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumVideo, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.OneOf<global::Vellum.VellumVideo, object> Value { get; set; }

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
        /// Initializes a new instance of the <see cref="ScenarioInputVideoVariableValue" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="inputVariableId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScenarioInputVideoVariableValue(
            global::Vellum.OneOf<global::Vellum.VellumVideo, object> value,
            string inputVariableId,
            global::Vellum.VideoEnum type)
        {
            this.Type = type;
            this.Value = value;
            this.InputVariableId = inputVariableId ?? throw new global::System.ArgumentNullException(nameof(inputVariableId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioInputVideoVariableValue" /> class.
        /// </summary>
        public ScenarioInputVideoVariableValue()
        {
        }
    }
}