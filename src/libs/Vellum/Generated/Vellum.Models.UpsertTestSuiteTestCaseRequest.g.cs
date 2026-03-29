
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpsertTestSuiteTestCaseRequest
    {
        /// <summary>
        /// The Vellum-generated ID of an existing Test Case whose data you'd like to replace. If specified and no Test Case exists with this ID, a 404 will be returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// An ID external to Vellum that uniquely identifies the Test Case that you'd like to create/update. If there's a match on a Test Case that was previously created with the same external_id, it will be updated. Otherwise, a new Test Case will be created with this value as its external_id. If no external_id is specified, then a new Test Case will always be created.
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
        /// Initializes a new instance of the <see cref="UpsertTestSuiteTestCaseRequest" /> class.
        /// </summary>
        /// <param name="inputValues">
        /// Values for each of the Test Case's input variables
        /// </param>
        /// <param name="evaluationValues">
        /// Values for each of the Test Case's evaluation variables
        /// </param>
        /// <param name="id">
        /// The Vellum-generated ID of an existing Test Case whose data you'd like to replace. If specified and no Test Case exists with this ID, a 404 will be returned.
        /// </param>
        /// <param name="externalId">
        /// An ID external to Vellum that uniquely identifies the Test Case that you'd like to create/update. If there's a match on a Test Case that was previously created with the same external_id, it will be updated. Otherwise, a new Test Case will be created with this value as its external_id. If no external_id is specified, then a new Test Case will always be created.
        /// </param>
        /// <param name="label">
        /// A human-readable label used to convey the intention of this Test Case
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertTestSuiteTestCaseRequest(
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
        /// Initializes a new instance of the <see cref="UpsertTestSuiteTestCaseRequest" /> class.
        /// </summary>
        public UpsertTestSuiteTestCaseRequest()
        {
        }
    }
}