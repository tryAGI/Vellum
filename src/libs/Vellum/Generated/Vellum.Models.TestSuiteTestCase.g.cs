
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteTestCase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.TestCaseVariableValue> InputValues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.TestCaseVariableValue> EvaluationValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestCase" /> class.
        /// </summary>
        /// <param name="inputValues"></param>
        /// <param name="evaluationValues"></param>
        /// <param name="id"></param>
        /// <param name="externalId"></param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteTestCase(
            global::System.Collections.Generic.IList<global::Vellum.TestCaseVariableValue> inputValues,
            global::System.Collections.Generic.IList<global::Vellum.TestCaseVariableValue> evaluationValues,
            string? id,
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
        /// Initializes a new instance of the <see cref="TestSuiteTestCase" /> class.
        /// </summary>
        public TestSuiteTestCase()
        {
        }
    }
}