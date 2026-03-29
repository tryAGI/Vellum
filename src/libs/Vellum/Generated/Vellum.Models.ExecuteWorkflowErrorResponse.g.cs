
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteWorkflowErrorResponse
    {
        /// <summary>
        /// Details about why the request failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteWorkflowErrorResponse" /> class.
        /// </summary>
        /// <param name="detail">
        /// Details about why the request failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteWorkflowErrorResponse(
            string detail)
        {
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteWorkflowErrorResponse" /> class.
        /// </summary>
        public ExecuteWorkflowErrorResponse()
        {
        }
    }
}