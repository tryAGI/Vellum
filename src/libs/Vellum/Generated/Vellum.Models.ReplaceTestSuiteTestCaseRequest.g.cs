
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Information about the Test Case to replace
    /// </summary>
    public sealed partial class ReplaceTestSuiteTestCaseRequest
    {
        /// <summary>
        /// The Vellum-generated ID of the Test Case whose data you'd like to replace. Must specify either this or external_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The ID that was originally provided upon Test Case creation that uniquely identifies the Test Case whose data you'd like to replace. Must specify either this of id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceTestSuiteTestCaseRequest" /> class.
        /// </summary>
        /// <param name="inputValues">
        /// Values for each of the Test Case's input variables
        /// </param>
        /// <param name="evaluationValues">
        /// Values for each of the Test Case's evaluation variables
        /// </param>
        /// <param name="id">
        /// The Vellum-generated ID of the Test Case whose data you'd like to replace. Must specify either this or external_id.
        /// </param>
        /// <param name="externalId">
        /// The ID that was originally provided upon Test Case creation that uniquely identifies the Test Case whose data you'd like to replace. Must specify either this of id.
        /// </param>
        /// <param name="label">
        /// A human-readable label used to convey the intention of this Test Case
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplaceTestSuiteTestCaseRequest(
            global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValueRequest> inputValues,
            global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValueRequest> evaluationValues,
            global::System.Guid? id,
            string? externalId,
            string? label)
        {
            this.Id = id;
            this.ExternalId = externalId;
            this.Label = label;
            this.InputValues = inputValues ?? throw new global::System.ArgumentNullException(nameof(inputValues));
            this.EvaluationValues = evaluationValues ?? throw new global::System.ArgumentNullException(nameof(evaluationValues));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceTestSuiteTestCaseRequest" /> class.
        /// </summary>
        public ReplaceTestSuiteTestCaseRequest()
        {
        }
    }
}