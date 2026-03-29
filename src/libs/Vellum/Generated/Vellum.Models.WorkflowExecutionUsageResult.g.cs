
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionUsageResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::System.Collections.Generic.IList<global::Vellum.MLModelUsageWrapper>? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public global::System.Collections.Generic.IList<global::Vellum.Price>? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowExecutionUsageCalculationError, object>))]
        public global::Vellum.OneOf<global::Vellum.WorkflowExecutionUsageCalculationError, object>? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionUsageResult" /> class.
        /// </summary>
        /// <param name="usage"></param>
        /// <param name="cost"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionUsageResult(
            global::System.Collections.Generic.IList<global::Vellum.MLModelUsageWrapper>? usage,
            global::System.Collections.Generic.IList<global::Vellum.Price>? cost,
            global::Vellum.OneOf<global::Vellum.WorkflowExecutionUsageCalculationError, object>? error)
        {
            this.Usage = usage;
            this.Cost = cost;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionUsageResult" /> class.
        /// </summary>
        public WorkflowExecutionUsageResult()
        {
        }
    }
}