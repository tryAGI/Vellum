
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Output for a test suite run metric that is of type NUMBER
    /// </summary>
    public sealed partial class TestSuiteRunMetricJSONOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// * `JSON` - JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.TestSuiteRunMetricJSONOutputTypeEnumJsonConverter))]
        public global::Vellum.TestSuiteRunMetricJSONOutputTypeEnum? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="TestSuiteRunMetricJSONOutput" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// * `JSON` - JSON
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunMetricJSONOutput(
            object value,
            string name,
            global::Vellum.TestSuiteRunMetricJSONOutputTypeEnum? type)
        {
            this.Value = value;
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunMetricJSONOutput" /> class.
        /// </summary>
        public TestSuiteRunMetricJSONOutput()
        {
        }
    }
}