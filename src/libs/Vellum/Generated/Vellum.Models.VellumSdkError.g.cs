
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VellumSdkError
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumSdkErrorRawData?, object>))]
        public global::Vellum.OneOf<global::Vellum.VellumSdkErrorRawData?, object>? RawData { get; set; }

        /// <summary>
        /// * `INVALID_WORKFLOW` - INVALID_WORKFLOW<br/>
        /// * `INVALID_INPUTS` - INVALID_INPUTS<br/>
        /// * `INVALID_OUTPUTS` - INVALID_OUTPUTS<br/>
        /// * `INVALID_STATE` - INVALID_STATE<br/>
        /// * `INVALID_CODE` - INVALID_CODE<br/>
        /// * `INVALID_TEMPLATE` - INVALID_TEMPLATE<br/>
        /// * `INTERNAL_ERROR` - INTERNAL_ERROR<br/>
        /// * `PROVIDER_CREDENTIALS_UNAVAILABLE` - PROVIDER_CREDENTIALS_UNAVAILABLE<br/>
        /// * `INTEGRATION_CREDENTIALS_UNAVAILABLE` - INTEGRATION_CREDENTIALS_UNAVAILABLE<br/>
        /// * `PROVIDER_ERROR` - PROVIDER_ERROR<br/>
        /// * `PROVIDER_QUOTA_EXCEEDED` - PROVIDER_QUOTA_EXCEEDED<br/>
        /// * `USER_DEFINED_ERROR` - USER_DEFINED_ERROR<br/>
        /// * `WORKFLOW_CANCELLED` - WORKFLOW_CANCELLED<br/>
        /// * `WORKFLOW_TIMEOUT` - WORKFLOW_TIMEOUT<br/>
        /// * `NODE_CANCELLED` - NODE_CANCELLED<br/>
        /// * `NODE_TIMEOUT` - NODE_TIMEOUT<br/>
        /// * `NODE_EXECUTION` - NODE_EXECUTION
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.VellumSdkErrorCodeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumSdkErrorCodeEnum Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumSdkError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="code">
        /// * `INVALID_WORKFLOW` - INVALID_WORKFLOW<br/>
        /// * `INVALID_INPUTS` - INVALID_INPUTS<br/>
        /// * `INVALID_OUTPUTS` - INVALID_OUTPUTS<br/>
        /// * `INVALID_STATE` - INVALID_STATE<br/>
        /// * `INVALID_CODE` - INVALID_CODE<br/>
        /// * `INVALID_TEMPLATE` - INVALID_TEMPLATE<br/>
        /// * `INTERNAL_ERROR` - INTERNAL_ERROR<br/>
        /// * `PROVIDER_CREDENTIALS_UNAVAILABLE` - PROVIDER_CREDENTIALS_UNAVAILABLE<br/>
        /// * `INTEGRATION_CREDENTIALS_UNAVAILABLE` - INTEGRATION_CREDENTIALS_UNAVAILABLE<br/>
        /// * `PROVIDER_ERROR` - PROVIDER_ERROR<br/>
        /// * `PROVIDER_QUOTA_EXCEEDED` - PROVIDER_QUOTA_EXCEEDED<br/>
        /// * `USER_DEFINED_ERROR` - USER_DEFINED_ERROR<br/>
        /// * `WORKFLOW_CANCELLED` - WORKFLOW_CANCELLED<br/>
        /// * `WORKFLOW_TIMEOUT` - WORKFLOW_TIMEOUT<br/>
        /// * `NODE_CANCELLED` - NODE_CANCELLED<br/>
        /// * `NODE_TIMEOUT` - NODE_TIMEOUT<br/>
        /// * `NODE_EXECUTION` - NODE_EXECUTION
        /// </param>
        /// <param name="rawData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VellumSdkError(
            string message,
            global::Vellum.VellumSdkErrorCodeEnum code,
            global::Vellum.OneOf<global::Vellum.VellumSdkErrorRawData?, object>? rawData)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RawData = rawData;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumSdkError" /> class.
        /// </summary>
        public VellumSdkError()
        {
        }
    }
}