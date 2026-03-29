
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Output for a test suite run metric that is of type ERROR
    /// </summary>
    public sealed partial class TestSuiteRunMetricErrorOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumError Value { get; set; }

        /// <summary>
        /// * `ERROR` - ERROR
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.TestSuiteRunMetricErrorOutputTypeEnumJsonConverter))]
        public global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="TestSuiteRunMetricErrorOutput" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// * `ERROR` - ERROR
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunMetricErrorOutput(
            global::Vellum.VellumError value,
            string name,
            global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum? type)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunMetricErrorOutput" /> class.
        /// </summary>
        public TestSuiteRunMetricErrorOutput()
        {
        }
    }
}