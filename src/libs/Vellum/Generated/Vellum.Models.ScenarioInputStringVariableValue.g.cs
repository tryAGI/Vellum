
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Prompt Sandbox Scenario input value that is of type STRING
    /// </summary>
    public sealed partial class ScenarioInputStringVariableValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.StringEnumJsonConverter))]
        public global::Vellum.StringEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

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
        /// Initializes a new instance of the <see cref="ScenarioInputStringVariableValue" /> class.
        /// </summary>
        /// <param name="inputVariableId"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScenarioInputStringVariableValue(
            string inputVariableId,
            global::Vellum.StringEnum type,
            string? value)
        {
            this.Type = type;
            this.Value = value;
            this.InputVariableId = inputVariableId ?? throw new global::System.ArgumentNullException(nameof(inputVariableId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScenarioInputStringVariableValue" /> class.
        /// </summary>
        public ScenarioInputStringVariableValue()
        {
        }
    }
}