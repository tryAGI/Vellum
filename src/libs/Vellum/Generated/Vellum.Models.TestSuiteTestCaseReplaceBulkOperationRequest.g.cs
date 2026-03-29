
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A bulk operation that represents the replacing of a Test Case.
    /// </summary>
    public sealed partial class TestSuiteTestCaseReplaceBulkOperationRequest
    {
        /// <summary>
        /// An ID representing this specific operation. Can later be used to look up information about the operation's success in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ReplaceEnumJsonConverter))]
        public global::Vellum.ReplaceEnum Type { get; set; }

        /// <summary>
        /// Information about the Test Case to replace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.ReplaceTestSuiteTestCaseRequest Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestCaseReplaceBulkOperationRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID representing this specific operation. Can later be used to look up information about the operation's success in the response.
        /// </param>
        /// <param name="data">
        /// Information about the Test Case to replace
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteTestCaseReplaceBulkOperationRequest(
            global::System.Guid id,
            global::Vellum.ReplaceTestSuiteTestCaseRequest data,
            global::Vellum.ReplaceEnum type)
        {
            this.Id = id;
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestCaseReplaceBulkOperationRequest" /> class.
        /// </summary>
        public TestSuiteTestCaseReplaceBulkOperationRequest()
        {
        }
    }
}