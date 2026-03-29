
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunProgress
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_requested_test_cases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumberOfRequestedTestCases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_completed_test_cases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumberOfCompletedTestCases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunProgress" /> class.
        /// </summary>
        /// <param name="numberOfRequestedTestCases"></param>
        /// <param name="numberOfCompletedTestCases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunProgress(
            int numberOfRequestedTestCases,
            int numberOfCompletedTestCases)
        {
            this.NumberOfRequestedTestCases = numberOfRequestedTestCases;
            this.NumberOfCompletedTestCases = numberOfCompletedTestCases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunProgress" /> class.
        /// </summary>
        public TestSuiteRunProgress()
        {
        }
    }
}