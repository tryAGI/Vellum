
#nullable enable

namespace Vellum
{
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
    public enum VellumSdkErrorCodeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        IntegrationCredentialsUnavailable,
        /// <summary>
        /// 
        /// </summary>
        InternalError,
        /// <summary>
        /// 
        /// </summary>
        InvalidCode,
        /// <summary>
        /// 
        /// </summary>
        InvalidInputs,
        /// <summary>
        /// 
        /// </summary>
        InvalidOutputs,
        /// <summary>
        /// 
        /// </summary>
        InvalidState,
        /// <summary>
        /// 
        /// </summary>
        InvalidTemplate,
        /// <summary>
        /// 
        /// </summary>
        InvalidWorkflow,
        /// <summary>
        /// 
        /// </summary>
        NodeCancelled,
        /// <summary>
        /// 
        /// </summary>
        NodeExecution,
        /// <summary>
        /// 
        /// </summary>
        NodeTimeout,
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
        UserDefinedError,
        /// <summary>
        /// 
        /// </summary>
        WorkflowCancelled,
        /// <summary>
        /// 
        /// </summary>
        WorkflowTimeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VellumSdkErrorCodeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VellumSdkErrorCodeEnum value)
        {
            return value switch
            {
                VellumSdkErrorCodeEnum.IntegrationCredentialsUnavailable => "INTEGRATION_CREDENTIALS_UNAVAILABLE",
                VellumSdkErrorCodeEnum.InternalError => "INTERNAL_ERROR",
                VellumSdkErrorCodeEnum.InvalidCode => "INVALID_CODE",
                VellumSdkErrorCodeEnum.InvalidInputs => "INVALID_INPUTS",
                VellumSdkErrorCodeEnum.InvalidOutputs => "INVALID_OUTPUTS",
                VellumSdkErrorCodeEnum.InvalidState => "INVALID_STATE",
                VellumSdkErrorCodeEnum.InvalidTemplate => "INVALID_TEMPLATE",
                VellumSdkErrorCodeEnum.InvalidWorkflow => "INVALID_WORKFLOW",
                VellumSdkErrorCodeEnum.NodeCancelled => "NODE_CANCELLED",
                VellumSdkErrorCodeEnum.NodeExecution => "NODE_EXECUTION",
                VellumSdkErrorCodeEnum.NodeTimeout => "NODE_TIMEOUT",
                VellumSdkErrorCodeEnum.ProviderCredentialsUnavailable => "PROVIDER_CREDENTIALS_UNAVAILABLE",
                VellumSdkErrorCodeEnum.ProviderError => "PROVIDER_ERROR",
                VellumSdkErrorCodeEnum.ProviderQuotaExceeded => "PROVIDER_QUOTA_EXCEEDED",
                VellumSdkErrorCodeEnum.UserDefinedError => "USER_DEFINED_ERROR",
                VellumSdkErrorCodeEnum.WorkflowCancelled => "WORKFLOW_CANCELLED",
                VellumSdkErrorCodeEnum.WorkflowTimeout => "WORKFLOW_TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VellumSdkErrorCodeEnum? ToEnum(string value)
        {
            return value switch
            {
                "INTEGRATION_CREDENTIALS_UNAVAILABLE" => VellumSdkErrorCodeEnum.IntegrationCredentialsUnavailable,
                "INTERNAL_ERROR" => VellumSdkErrorCodeEnum.InternalError,
                "INVALID_CODE" => VellumSdkErrorCodeEnum.InvalidCode,
                "INVALID_INPUTS" => VellumSdkErrorCodeEnum.InvalidInputs,
                "INVALID_OUTPUTS" => VellumSdkErrorCodeEnum.InvalidOutputs,
                "INVALID_STATE" => VellumSdkErrorCodeEnum.InvalidState,
                "INVALID_TEMPLATE" => VellumSdkErrorCodeEnum.InvalidTemplate,
                "INVALID_WORKFLOW" => VellumSdkErrorCodeEnum.InvalidWorkflow,
                "NODE_CANCELLED" => VellumSdkErrorCodeEnum.NodeCancelled,
                "NODE_EXECUTION" => VellumSdkErrorCodeEnum.NodeExecution,
                "NODE_TIMEOUT" => VellumSdkErrorCodeEnum.NodeTimeout,
                "PROVIDER_CREDENTIALS_UNAVAILABLE" => VellumSdkErrorCodeEnum.ProviderCredentialsUnavailable,
                "PROVIDER_ERROR" => VellumSdkErrorCodeEnum.ProviderError,
                "PROVIDER_QUOTA_EXCEEDED" => VellumSdkErrorCodeEnum.ProviderQuotaExceeded,
                "USER_DEFINED_ERROR" => VellumSdkErrorCodeEnum.UserDefinedError,
                "WORKFLOW_CANCELLED" => VellumSdkErrorCodeEnum.WorkflowCancelled,
                "WORKFLOW_TIMEOUT" => VellumSdkErrorCodeEnum.WorkflowTimeout,
                _ => null,
            };
        }
    }
}