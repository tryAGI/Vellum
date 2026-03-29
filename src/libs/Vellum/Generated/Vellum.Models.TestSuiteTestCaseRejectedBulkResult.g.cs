
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The result of a bulk operation that failed to operate on a Test Case.
    /// </summary>
    public sealed partial class TestSuiteTestCaseRejectedBulkResult
    {
        /// <summary>
        /// An ID that maps back to one of the initially supplied operations. Can be used to determine the result of a given operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.RejectedEnumJsonConverter))]
        public global::Vellum.RejectedEnum Type { get; set; }

        /// <summary>
        /// Details about the error that occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestCaseRejectedBulkResult" /> class.
        /// </summary>
        /// <param name="data">
        /// Details about the error that occurred
        /// </param>
        /// <param name="id">
        /// An ID that maps back to one of the initially supplied operations. Can be used to determine the result of a given operation.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteTestCaseRejectedBulkResult(
            object data,
            global::System.Guid? id,
            global::Vellum.RejectedEnum type)
        {
            this.Id = id;
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestCaseRejectedBulkResult" /> class.
        /// </summary>
        public TestSuiteTestCaseRejectedBulkResult()
        {
        }
    }
}