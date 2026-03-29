
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Execution configuration for running a Test Suite against a Prompt Sandbox
    /// </summary>
    public sealed partial class TestSuiteRunPromptSandboxExecConfigRequest
    {
        /// <summary>
        /// * `PROMPT_SANDBOX` - PROMPT_SANDBOX
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.TestSuiteRunPromptSandboxExecConfigTypeEnumJsonConverter))]
        public global::Vellum.TestSuiteRunPromptSandboxExecConfigTypeEnum? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.TestSuiteRunPromptSandboxExecConfigDataRequest Data { get; set; }

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
        /// Initializes a new instance of the <see cref="TestSuiteRunPromptSandboxExecConfigRequest" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type">
        /// * `PROMPT_SANDBOX` - PROMPT_SANDBOX
        /// </param>
        /// <param name="testCaseIds">
        /// Optionally specify a subset of test case ids to run. If not provided, all test cases within the test suite will be run by default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunPromptSandboxExecConfigRequest(
            global::Vellum.TestSuiteRunPromptSandboxExecConfigDataRequest data,
            global::Vellum.TestSuiteRunPromptSandboxExecConfigTypeEnum? type,
            global::System.Collections.Generic.IList<string>? testCaseIds)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TestCaseIds = testCaseIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunPromptSandboxExecConfigRequest" /> class.
        /// </summary>
        public TestSuiteRunPromptSandboxExecConfigRequest()
        {
        }
    }
}