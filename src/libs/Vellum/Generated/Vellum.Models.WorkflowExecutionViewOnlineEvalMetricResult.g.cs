
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionViewOnlineEvalMetricResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.ExecutionVellumValue> Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid MetricId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionViewOnlineEvalMetricResult" /> class.
        /// </summary>
        /// <param name="outputs"></param>
        /// <param name="label"></param>
        /// <param name="metricId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionViewOnlineEvalMetricResult(
            global::System.Collections.Generic.IList<global::Vellum.ExecutionVellumValue> outputs,
            string label,
            global::System.Guid metricId)
        {
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.MetricId = metricId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionViewOnlineEvalMetricResult" /> class.
        /// </summary>
        public WorkflowExecutionViewOnlineEvalMetricResult()
        {
        }
    }
}