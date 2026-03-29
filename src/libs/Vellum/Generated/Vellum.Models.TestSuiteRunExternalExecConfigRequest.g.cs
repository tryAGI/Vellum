
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Execution configuration for running a Vellum Test Suite against an external callable
    /// </summary>
    public sealed partial class TestSuiteRunExternalExecConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.TestSuiteRunExternalExecConfigDataRequest Data { get; set; }

        /// <summary>
        /// Optionally specify a subset of test case ids to run. If not provided, all test cases within the test suite will be run by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_ids")]
        public global::System.Collections.Generic.IList<string>? TestCaseIds { get; set; }

        /// <summary>
        /// * `EXTERNAL` - EXTERNAL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.TestSuiteRunExternalExecConfigTypeEnumJsonConverter))]
        public global::Vellum.TestSuiteRunExternalExecConfigTypeEnum? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunExternalExecConfigRequest" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="testCaseIds">
        /// Optionally specify a subset of test case ids to run. If not provided, all test cases within the test suite will be run by default.
        /// </param>
        /// <param name="type">
        /// * `EXTERNAL` - EXTERNAL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunExternalExecConfigRequest(
            global::Vellum.TestSuiteRunExternalExecConfigDataRequest data,
            global::System.Collections.Generic.IList<string>? testCaseIds,
            global::Vellum.TestSuiteRunExternalExecConfigTypeEnum? type)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TestCaseIds = testCaseIds;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunExternalExecConfigRequest" /> class.
        /// </summary>
        public TestSuiteRunExternalExecConfigRequest()
        {
        }
    }
}