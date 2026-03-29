
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Execution configuration for running a Test Suite against a Workflow Sandbox History Item
    /// </summary>
    public sealed partial class TestSuiteRunWorkflowSandboxHistoryItemExecConfig
    {
        /// <summary>
        /// * `WORKFLOW_SANDBOX_HISTORY_ITEM` - WORKFLOW_SANDBOX_HISTORY_ITEM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnumJsonConverter))]
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigData Data { get; set; }

        /// <summary>
        /// Optionally specify a subset of test case ids to run. If not provided, all test cases within the test suite will be run by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_ids")]
        public global::System.Collections.Generic.IList<string>? TestCaseIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunWorkflowSandboxHistoryItemExecConfig" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">
        /// * `WORKFLOW_SANDBOX_HISTORY_ITEM` - WORKFLOW_SANDBOX_HISTORY_ITEM
        /// </param>
        /// <param name="testCaseIds">
        /// Optionally specify a subset of test case ids to run. If not provided, all test cases within the test suite will be run by default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunWorkflowSandboxHistoryItemExecConfig(
            global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigData data,
            global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum? type,
            global::System.Collections.Generic.IList<string>? testCaseIds)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TestCaseIds = testCaseIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunWorkflowSandboxHistoryItemExecConfig" /> class.
        /// </summary>
        public TestSuiteRunWorkflowSandboxHistoryItemExecConfig()
        {
        }
    }
}