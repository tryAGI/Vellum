
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunCreateRequest
    {
        /// <summary>
        /// The ID of the Test Suite to run. Must provide either this or test_suite_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_suite_id")]
        public global::System.Guid? TestSuiteId { get; set; }

        /// <summary>
        /// The name of the Test Suite to run. Must provide either this or test_suite_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_suite_name")]
        public string? TestSuiteName { get; set; }

        /// <summary>
        /// Configuration that defines how the Test Suite should be run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exec_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.TestSuiteRunExecConfigRequestJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.TestSuiteRunExecConfigRequest ExecConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunCreateRequest" /> class.
        /// </summary>
        /// <param name="execConfig">
        /// Configuration that defines how the Test Suite should be run
        /// </param>
        /// <param name="testSuiteId">
        /// The ID of the Test Suite to run. Must provide either this or test_suite_id.
        /// </param>
        /// <param name="testSuiteName">
        /// The name of the Test Suite to run. Must provide either this or test_suite_id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunCreateRequest(
            global::Vellum.TestSuiteRunExecConfigRequest execConfig,
            global::System.Guid? testSuiteId,
            string? testSuiteName)
        {
            this.TestSuiteId = testSuiteId;
            this.TestSuiteName = testSuiteName;
            this.ExecConfig = execConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunCreateRequest" /> class.
        /// </summary>
        public TestSuiteRunCreateRequest()
        {
        }
    }
}