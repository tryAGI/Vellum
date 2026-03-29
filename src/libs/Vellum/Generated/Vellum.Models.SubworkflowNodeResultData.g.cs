
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubworkflowNodeResultData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        public global::System.Guid? ExecutionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubworkflowNodeResultData" /> class.
        /// </summary>
        /// <param name="executionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubworkflowNodeResultData(
            global::System.Guid? executionId)
        {
            this.ExecutionId = executionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubworkflowNodeResultData" /> class.
        /// </summary>
        public SubworkflowNodeResultData()
        {
        }
    }
}