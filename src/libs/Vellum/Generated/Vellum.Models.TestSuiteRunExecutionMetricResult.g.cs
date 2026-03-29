
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunExecutionMetricResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid MetricId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunMetricOutput> Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_label")]
        public string? MetricLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_definition")]
        public global::Vellum.TestSuiteRunExecutionMetricDefinition? MetricDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunExecutionMetricResult" /> class.
        /// </summary>
        /// <param name="metricId"></param>
        /// <param name="outputs"></param>
        /// <param name="metricLabel"></param>
        /// <param name="metricDefinition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunExecutionMetricResult(
            global::System.Guid metricId,
            global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunMetricOutput> outputs,
            string? metricLabel,
            global::Vellum.TestSuiteRunExecutionMetricDefinition? metricDefinition)
        {
            this.MetricId = metricId;
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.MetricLabel = metricLabel;
            this.MetricDefinition = metricDefinition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunExecutionMetricResult" /> class.
        /// </summary>
        public TestSuiteRunExecutionMetricResult()
        {
        }
    }
}