
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExternalTestCaseExecutionRequest
    {
        /// <summary>
        /// The output values of a callable that was executed against a Test Case outside of Vellum
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValueRequest> Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestCaseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalTestCaseExecutionRequest" /> class.
        /// </summary>
        /// <param name="outputs">
        /// The output values of a callable that was executed against a Test Case outside of Vellum
        /// </param>
        /// <param name="testCaseId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalTestCaseExecutionRequest(
            global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValueRequest> outputs,
            string testCaseId)
        {
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.TestCaseId = testCaseId ?? throw new global::System.ArgumentNullException(nameof(testCaseId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalTestCaseExecutionRequest" /> class.
        /// </summary>
        public ExternalTestCaseExecutionRequest()
        {
        }
    }
}