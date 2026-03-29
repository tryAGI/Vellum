
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The result of a bulk operation that created a Test Case.
    /// </summary>
    public sealed partial class TestSuiteTestCaseCreatedBulkResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.CreatedEnumJsonConverter))]
        public global::Vellum.CreatedEnum Type { get; set; }

        /// <summary>
        /// Information about the Test Case that was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.TestSuiteTestCaseCreatedBulkResultData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestCaseCreatedBulkResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data">
        /// Information about the Test Case that was created.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteTestCaseCreatedBulkResult(
            global::System.Guid id,
            global::Vellum.TestSuiteTestCaseCreatedBulkResultData data,
            global::Vellum.CreatedEnum type)
        {
            this.Id = id;
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestCaseCreatedBulkResult" /> class.
        /// </summary>
        public TestSuiteTestCaseCreatedBulkResult()
        {
        }
    }
}