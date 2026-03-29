
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorDetailResponse
    {
        /// <summary>
        /// Message informing the user of the error.
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
        /// Initializes a new instance of the <see cref="ErrorDetailResponse" /> class.
        /// </summary>
        /// <param name="detail">
        /// Message informing the user of the error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorDetailResponse(
            string detail)
        {
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetailResponse" /> class.
        /// </summary>
        public ErrorDetailResponse()
        {
        }
    }
}