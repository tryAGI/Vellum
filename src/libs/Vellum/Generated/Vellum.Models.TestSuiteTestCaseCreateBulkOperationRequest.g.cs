
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A bulk operation that represents the creation of a Test Case.
    /// </summary>
    public sealed partial class TestSuiteTestCaseCreateBulkOperationRequest
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.CreateEnumJsonConverter))]
        public global::Vellum.CreateEnum Type { get; set; }

        /// <summary>
        /// Information about the Test Case to create
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.CreateTestSuiteTestCaseRequest Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestCaseCreateBulkOperationRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// An ID representing this specific operation. Can later be used to look up information about the operation's success in the response.
        /// </param>
        /// <param name="data">
        /// Information about the Test Case to create
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteTestCaseCreateBulkOperationRequest(
            global::System.Guid id,
            global::Vellum.CreateTestSuiteTestCaseRequest data,
            global::Vellum.CreateEnum type)
        {
            this.Id = id;
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestCaseCreateBulkOperationRequest" /> class.
        /// </summary>
        public TestSuiteTestCaseCreateBulkOperationRequest()
        {
        }
    }
}