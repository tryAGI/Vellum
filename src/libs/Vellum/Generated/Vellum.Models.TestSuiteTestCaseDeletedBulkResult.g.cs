
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The result of a bulk operation that deleted a Test Case.
    /// </summary>
    public sealed partial class TestSuiteTestCaseDeletedBulkResult
    {
        /// <summary>
        /// An ID that maps back to one of the initially supplied operations. Can be used to determine the result of a given operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.DeletedEnumJsonConverter))]
        public global::Vellum.DeletedEnum Type { get; set; }

        /// <summary>
        /// Information about the Test Case that was deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.TestSuiteTestCaseDeletedBulkResultData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestCaseDeletedBulkResult" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID that maps back to one of the initially supplied operations. Can be used to determine the result of a given operation.
        /// </param>
        /// <param name="data">
        /// Information about the Test Case that was deleted
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteTestCaseDeletedBulkResult(
            global::System.Guid id,
            global::Vellum.TestSuiteTestCaseDeletedBulkResultData data,
            global::Vellum.DeletedEnum type)
        {
            this.Id = id;
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestCaseDeletedBulkResult" /> class.
        /// </summary>
        public TestSuiteTestCaseDeletedBulkResult()
        {
        }
    }
}