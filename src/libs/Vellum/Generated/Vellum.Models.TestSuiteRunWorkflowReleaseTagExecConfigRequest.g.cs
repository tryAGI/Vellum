
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Execution configuration for running a Test Suite against a Workflow Deployment
    /// </summary>
    public sealed partial class TestSuiteRunWorkflowReleaseTagExecConfigRequest
    {
        /// <summary>
        /// * `WORKFLOW_RELEASE_TAG` - WORKFLOW_RELEASE_TAG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnumJsonConverter))]
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigDataRequest Data { get; set; }

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
        /// Initializes a new instance of the <see cref="TestSuiteRunWorkflowReleaseTagExecConfigRequest" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">
        /// * `WORKFLOW_RELEASE_TAG` - WORKFLOW_RELEASE_TAG
        /// </param>
        /// <param name="testCaseIds">
        /// Optionally specify a subset of test case ids to run. If not provided, all test cases within the test suite will be run by default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunWorkflowReleaseTagExecConfigRequest(
            global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigDataRequest data,
            global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum? type,
            global::System.Collections.Generic.IList<string>? testCaseIds)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TestCaseIds = testCaseIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunWorkflowReleaseTagExecConfigRequest" /> class.
        /// </summary>
        public TestSuiteRunWorkflowReleaseTagExecConfigRequest()
        {
        }
    }
}