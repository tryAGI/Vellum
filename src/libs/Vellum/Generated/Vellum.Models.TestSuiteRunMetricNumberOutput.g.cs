
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Output for a test suite run metric that is of type NUMBER
    /// </summary>
    public sealed partial class TestSuiteRunMetricNumberOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// * `NUMBER` - NUMBER
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.TestSuiteRunMetricNumberOutputTypeEnumJsonConverter))]
        public global::Vellum.TestSuiteRunMetricNumberOutputTypeEnum? Type { get; set; }

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
        /// Initializes a new instance of the <see cref="TestSuiteRunMetricNumberOutput" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="type">
        /// * `NUMBER` - NUMBER
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunMetricNumberOutput(
            string name,
            double? value,
            global::Vellum.TestSuiteRunMetricNumberOutputTypeEnum? type)
        {
            this.Value = value;
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunMetricNumberOutput" /> class.
        /// </summary>
        public TestSuiteRunMetricNumberOutput()
        {
        }
    }
}