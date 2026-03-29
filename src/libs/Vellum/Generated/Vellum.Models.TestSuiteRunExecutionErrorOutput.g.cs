
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Execution output of an entity evaluated during a Test Suite Run that is of type ERROR
    /// </summary>
    public sealed partial class TestSuiteRunExecutionErrorOutput
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ErrorEnumJsonConverter))]
        public global::Vellum.ErrorEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumError, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.OneOf<global::Vellum.VellumError, object> Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_variable_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OutputVariableId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunExecutionErrorOutput" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="outputVariableId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunExecutionErrorOutput(
            string name,
            global::Vellum.OneOf<global::Vellum.VellumError, object> value,
            global::System.Guid outputVariableId,
            global::Vellum.ErrorEnum type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Value = value;
            this.OutputVariableId = outputVariableId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunExecutionErrorOutput" /> class.
        /// </summary>
        public TestSuiteRunExecutionErrorOutput()
        {
        }
    }
}