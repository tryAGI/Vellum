
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConditionalNodeResultData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_handle_id")]
        public string? SourceHandleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalNodeResultData" /> class.
        /// </summary>
        /// <param name="sourceHandleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConditionalNodeResultData(
            string? sourceHandleId)
        {
            this.SourceHandleId = sourceHandleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalNodeResultData" /> class.
        /// </summary>
        public ConditionalNodeResultData()
        {
        }
    }
}