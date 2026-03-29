
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Information about the Test Case to create
    /// </summary>
    public sealed partial class CreateTestSuiteTestCaseRequest
    {
        /// <summary>
        /// A human-readable label used to convey the intention of this Test Case
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Values for each of the Test Case's input variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValueRequest> InputValues { get; set; }

        /// <summary>
        /// Values for each of the Test Case's evaluation variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValueRequest> EvaluationValues { get; set; }

        /// <summary>
        /// Optionally provide an ID that uniquely identifies this Test Case in your system. Useful for updating this Test Cases data after initial creation. Cannot be changed later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTestSuiteTestCaseRequest" /> class.
        /// </summary>
        /// <param name="inputValues">
        /// Values for each of the Test Case's input variables
        /// </param>
        /// <param name="evaluationValues">
        /// Values for each of the Test Case's evaluation variables
        /// </param>
        /// <param name="label">
        /// A human-readable label used to convey the intention of this Test Case
        /// </param>
        /// <param name="externalId">
        /// Optionally provide an ID that uniquely identifies this Test Case in your system. Useful for updating this Test Cases data after initial creation. Cannot be changed later.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTestSuiteTestCaseRequest(
            global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValueRequest> inputValues,
            global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValueRequest> evaluationValues,
            string? label,
            string? externalId)
        {
            this.Label = label;
            this.InputValues = inputValues ?? throw new global::System.ArgumentNullException(nameof(inputValues));
            this.EvaluationValues = evaluationValues ?? throw new global::System.ArgumentNullException(nameof(evaluationValues));
            this.ExternalId = externalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTestSuiteTestCaseRequest" /> class.
        /// </summary>
        public CreateTestSuiteTestCaseRequest()
        {
        }
    }
}