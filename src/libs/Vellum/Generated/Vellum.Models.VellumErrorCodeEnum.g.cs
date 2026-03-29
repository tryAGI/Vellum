
#nullable enable

namespace Vellum
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
    public enum VellumErrorCodeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        ChatQuotaExceeded,
        /// <summary>
        /// 
        /// </summary>
        IntegrationCredentialsUnavailable,
        /// <summary>
        /// 
        /// </summary>
        InternalServerError,
        /// <summary>
        /// 
        /// </summary>
        InvalidInputs,
        /// <summary>
        /// 
        /// </summary>
        InvalidRequest,
        /// <summary>
        /// 
        /// </summary>
        NodeCancelled,
        /// <summary>
        /// 
        /// </summary>
        ProviderCredentialsUnavailable,
        /// <summary>
        /// 
        /// </summary>
        ProviderError,
        /// <summary>
        /// 
        /// </summary>
        ProviderQuotaExceeded,
        /// <summary>
        /// 
        /// </summary>
        RequestTimeout,
        /// <summary>
        /// 
        /// </summary>
        UserDefinedError,
        /// <summary>
        /// 
        /// </summary>
        WorkflowCancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VellumErrorCodeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VellumErrorCodeEnum value)
        {
            return value switch
            {
                VellumErrorCodeEnum.ChatQuotaExceeded => "CHAT_QUOTA_EXCEEDED",
                VellumErrorCodeEnum.IntegrationCredentialsUnavailable => "INTEGRATION_CREDENTIALS_UNAVAILABLE",
                VellumErrorCodeEnum.InternalServerError => "INTERNAL_SERVER_ERROR",
                VellumErrorCodeEnum.InvalidInputs => "INVALID_INPUTS",
                VellumErrorCodeEnum.InvalidRequest => "INVALID_REQUEST",
                VellumErrorCodeEnum.NodeCancelled => "NODE_CANCELLED",
                VellumErrorCodeEnum.ProviderCredentialsUnavailable => "PROVIDER_CREDENTIALS_UNAVAILABLE",
                VellumErrorCodeEnum.ProviderError => "PROVIDER_ERROR",
                VellumErrorCodeEnum.ProviderQuotaExceeded => "PROVIDER_QUOTA_EXCEEDED",
                VellumErrorCodeEnum.RequestTimeout => "REQUEST_TIMEOUT",
                VellumErrorCodeEnum.UserDefinedError => "USER_DEFINED_ERROR",
                VellumErrorCodeEnum.WorkflowCancelled => "WORKFLOW_CANCELLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VellumErrorCodeEnum? ToEnum(string value)
        {
            return value switch
            {
                "CHAT_QUOTA_EXCEEDED" => VellumErrorCodeEnum.ChatQuotaExceeded,
                "INTEGRATION_CREDENTIALS_UNAVAILABLE" => VellumErrorCodeEnum.IntegrationCredentialsUnavailable,
                "INTERNAL_SERVER_ERROR" => VellumErrorCodeEnum.InternalServerError,
                "INVALID_INPUTS" => VellumErrorCodeEnum.InvalidInputs,
                "INVALID_REQUEST" => VellumErrorCodeEnum.InvalidRequest,
                "NODE_CANCELLED" => VellumErrorCodeEnum.NodeCancelled,
                "PROVIDER_CREDENTIALS_UNAVAILABLE" => VellumErrorCodeEnum.ProviderCredentialsUnavailable,
                "PROVIDER_ERROR" => VellumErrorCodeEnum.ProviderError,
                "PROVIDER_QUOTA_EXCEEDED" => VellumErrorCodeEnum.ProviderQuotaExceeded,
                "REQUEST_TIMEOUT" => VellumErrorCodeEnum.RequestTimeout,
                "USER_DEFINED_ERROR" => VellumErrorCodeEnum.UserDefinedError,
                "WORKFLOW_CANCELLED" => VellumErrorCodeEnum.WorkflowCancelled,
                _ => null,
            };
        }
    }
}