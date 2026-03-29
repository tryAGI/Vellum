
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VellumErrorRequest
    {
        /// <summary>
        /// * `INVALID_REQUEST` - INVALID_REQUEST<br/>
        /// * `INVALID_INPUTS` - INVALID_INPUTS<br/>
        /// * `PROVIDER_ERROR` - PROVIDER_ERROR<br/>
        /// * `PROVIDER_CREDENTIALS_UNAVAILABLE` - PROVIDER_CREDENTIALS_UNAVAILABLE<br/>
        /// * `INTEGRATION_CREDENTIALS_UNAVAILABLE` - INTEGRATION_CREDENTIALS_UNAVAILABLE<br/>
        /// * `REQUEST_TIMEOUT` - REQUEST_TIMEOUT<br/>
        /// * `INTERNAL_SERVER_ERROR` - INTERNAL_SERVER_ERROR<br/>
        /// * `USER_DEFINED_ERROR` - USER_DEFINED_ERROR<br/>
        /// * `WORKFLOW_CANCELLED` - WORKFLOW_CANCELLED<br/>
        /// * `NODE_CANCELLED` - NODE_CANCELLED<br/>
        /// * `PROVIDER_QUOTA_EXCEEDED` - PROVIDER_QUOTA_EXCEEDED<br/>
        /// * `CHAT_QUOTA_EXCEEDED` - CHAT_QUOTA_EXCEEDED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.VellumErrorCodeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumErrorCodeEnum Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_data")]
        public object? RawData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumErrorRequest" /> class.
        /// </summary>
        /// <param name="code">
        /// * `INVALID_REQUEST` - INVALID_REQUEST<br/>
        /// * `INVALID_INPUTS` - INVALID_INPUTS<br/>
        /// * `PROVIDER_ERROR` - PROVIDER_ERROR<br/>
        /// * `PROVIDER_CREDENTIALS_UNAVAILABLE` - PROVIDER_CREDENTIALS_UNAVAILABLE<br/>
        /// * `INTEGRATION_CREDENTIALS_UNAVAILABLE` - INTEGRATION_CREDENTIALS_UNAVAILABLE<br/>
        /// * `REQUEST_TIMEOUT` - REQUEST_TIMEOUT<br/>
        /// * `INTERNAL_SERVER_ERROR` - INTERNAL_SERVER_ERROR<br/>
        /// * `USER_DEFINED_ERROR` - USER_DEFINED_ERROR<br/>
        /// * `WORKFLOW_CANCELLED` - WORKFLOW_CANCELLED<br/>
        /// * `NODE_CANCELLED` - NODE_CANCELLED<br/>
        /// * `PROVIDER_QUOTA_EXCEEDED` - PROVIDER_QUOTA_EXCEEDED<br/>
        /// * `CHAT_QUOTA_EXCEEDED` - CHAT_QUOTA_EXCEEDED
        /// </param>
        /// <param name="message"></param>
        /// <param name="rawData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VellumErrorRequest(
            global::Vellum.VellumErrorCodeEnum code,
            string message,
            object? rawData)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RawData = rawData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumErrorRequest" /> class.
        /// </summary>
        public VellumErrorRequest()
        {
        }
    }
}