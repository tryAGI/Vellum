
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Output for a test suite run metric that is of type STRING
    /// </summary>
    public sealed partial class TestSuiteRunMetricStringOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// * `STRING` - STRING
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.TestSuiteRunMetricStringOutputTypeEnumJsonConverter))]
        public global::Vellum.TestSuiteRunMetricStringOutputTypeEnum? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="TestSuiteRunMetricStringOutput" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="type">
        /// * `STRING` - STRING
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunMetricStringOutput(
            string name,
            string? value,
            global::Vellum.TestSuiteRunMetricStringOutputTypeEnum? type)
        {
            this.Value = value;
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunMetricStringOutput" /> class.
        /// </summary>
        public TestSuiteRunMetricStringOutput()
        {
        }
    }
}