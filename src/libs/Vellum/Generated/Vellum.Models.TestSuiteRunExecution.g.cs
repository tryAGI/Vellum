
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunExecution
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestCaseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunExecutionOutput> Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunExecutionMetricResult> MetricResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunExecution" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="testCaseId"></param>
        /// <param name="outputs"></param>
        /// <param name="metricResults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunExecution(
            global::System.Guid id,
            string testCaseId,
            global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunExecutionOutput> outputs,
            global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunExecutionMetricResult> metricResults)
        {
            this.Id = id;
            this.TestCaseId = testCaseId ?? throw new global::System.ArgumentNullException(nameof(testCaseId));
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.MetricResults = metricResults ?? throw new global::System.ArgumentNullException(nameof(metricResults));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunExecution" /> class.
        /// </summary>
        public TestSuiteRunExecution()
        {
        }
    }
}