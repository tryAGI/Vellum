
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionUsageCalculationFulfilledBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.MLModelUsageWrapper> Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.Price> Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionUsageCalculationFulfilledBody" /> class.
        /// </summary>
        /// <param name="usage"></param>
        /// <param name="cost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionUsageCalculationFulfilledBody(
            global::System.Collections.Generic.IList<global::Vellum.MLModelUsageWrapper> usage,
            global::System.Collections.Generic.IList<global::Vellum.Price> cost)
        {
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Cost = cost ?? throw new global::System.ArgumentNullException(nameof(cost));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionUsageCalculationFulfilledBody" /> class.
        /// </summary>
        public WorkflowExecutionUsageCalculationFulfilledBody()
        {
        }
    }
}