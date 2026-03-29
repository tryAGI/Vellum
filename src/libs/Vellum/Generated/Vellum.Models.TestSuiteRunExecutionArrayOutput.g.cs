
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Execution output of an entity evaluated during a Test Suite Run that is of type ARRAY
    /// </summary>
    public sealed partial class TestSuiteRunExecutionArrayOutput
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ArrayEnumJsonConverter))]
        public global::Vellum.ArrayEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::System.Collections.Generic.IList<global::Vellum.VellumValue>? Value { get; set; }

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
        /// Initializes a new instance of the <see cref="TestSuiteRunExecutionArrayOutput" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="outputVariableId"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunExecutionArrayOutput(
            string name,
            global::System.Guid outputVariableId,
            global::Vellum.ArrayEnum type,
            global::System.Collections.Generic.IList<global::Vellum.VellumValue>? value)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Value = value;
            this.OutputVariableId = outputVariableId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunExecutionArrayOutput" /> class.
        /// </summary>
        public TestSuiteRunExecutionArrayOutput()
        {
        }
    }
}