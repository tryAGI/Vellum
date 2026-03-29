
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunWorkflowSandboxHistoryItemExecConfigData
    {
        /// <summary>
        /// The ID of the Workflow Sandbox History Item that the Test Suite will run against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid HistoryItemId { get; set; }

        /// <summary>
        /// The ID of the Workflow Variant within the Workflow Sandbox History Item that you'd like to run the Test Suite against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_variant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkflowVariantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunWorkflowSandboxHistoryItemExecConfigData" /> class.
        /// </summary>
        /// <param name="historyItemId">
        /// The ID of the Workflow Sandbox History Item that the Test Suite will run against.
        /// </param>
        /// <param name="workflowVariantId">
        /// The ID of the Workflow Variant within the Workflow Sandbox History Item that you'd like to run the Test Suite against.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunWorkflowSandboxHistoryItemExecConfigData(
            global::System.Guid historyItemId,
            global::System.Guid workflowVariantId)
        {
            this.HistoryItemId = historyItemId;
            this.WorkflowVariantId = workflowVariantId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunWorkflowSandboxHistoryItemExecConfigData" /> class.
        /// </summary>
        public TestSuiteRunWorkflowSandboxHistoryItemExecConfigData()
        {
        }
    }
}