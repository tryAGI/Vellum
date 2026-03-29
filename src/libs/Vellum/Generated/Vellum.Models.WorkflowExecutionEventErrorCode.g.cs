
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `WORKFLOW_INITIALIZATION` - WORKFLOW_INITIALIZATION<br/>
    /// * `WORKFLOW_CANCELLED` - WORKFLOW_CANCELLED<br/>
    /// * `WORKFLOW_TIMEOUT` - WORKFLOW_TIMEOUT<br/>
    /// * `PROVIDER_CREDENTIALS_UNAVAILABLE` - PROVIDER_CREDENTIALS_UNAVAILABLE<br/>
    /// * `INTEGRATION_CREDENTIALS_UNAVAILABLE` - INTEGRATION_CREDENTIALS_UNAVAILABLE<br/>
    /// * `NODE_EXECUTION_COUNT_LIMIT_REACHED` - NODE_EXECUTION_COUNT_LIMIT_REACHED<br/>
    /// * `INTERNAL_SERVER_ERROR` - INTERNAL_SERVER_ERROR<br/>
    /// * `NODE_EXECUTION` - NODE_EXECUTION<br/>
    /// * `NODE_CANCELLED` - NODE_CANCELLED<br/>
    /// * `NODE_TIMEOUT` - NODE_TIMEOUT<br/>
    /// * `LLM_PROVIDER` - LLM_PROVIDER<br/>
    /// * `INVALID_TEMPLATE` - INVALID_TEMPLATE<br/>
    /// * `INVALID_INPUTS` - INVALID_INPUTS<br/>
    /// * `PROVIDER_QUOTA_EXCEEDED` - PROVIDER_QUOTA_EXCEEDED<br/>
    /// * `USER_DEFINED_ERROR` - USER_DEFINED_ERROR
    /// </summary>
    public enum WorkflowExecutionEventErrorCode
    {
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
        InvalidTemplate,
        /// <summary>
        /// 
        /// </summary>
        LlmProvider,
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
        NodeExecutionCountLimitReached,
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
        WorkflowInitialization,
        /// <summary>
        /// 
        /// </summary>
        WorkflowTimeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowExecutionEventErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowExecutionEventErrorCode value)
        {
            return value switch
            {
                WorkflowExecutionEventErrorCode.IntegrationCredentialsUnavailable => "INTEGRATION_CREDENTIALS_UNAVAILABLE",
                WorkflowExecutionEventErrorCode.InternalServerError => "INTERNAL_SERVER_ERROR",
                WorkflowExecutionEventErrorCode.InvalidInputs => "INVALID_INPUTS",
                WorkflowExecutionEventErrorCode.InvalidTemplate => "INVALID_TEMPLATE",
                WorkflowExecutionEventErrorCode.LlmProvider => "LLM_PROVIDER",
                WorkflowExecutionEventErrorCode.NodeCancelled => "NODE_CANCELLED",
                WorkflowExecutionEventErrorCode.NodeExecution => "NODE_EXECUTION",
                WorkflowExecutionEventErrorCode.NodeExecutionCountLimitReached => "NODE_EXECUTION_COUNT_LIMIT_REACHED",
                WorkflowExecutionEventErrorCode.NodeTimeout => "NODE_TIMEOUT",
                WorkflowExecutionEventErrorCode.ProviderCredentialsUnavailable => "PROVIDER_CREDENTIALS_UNAVAILABLE",
                WorkflowExecutionEventErrorCode.ProviderQuotaExceeded => "PROVIDER_QUOTA_EXCEEDED",
                WorkflowExecutionEventErrorCode.UserDefinedError => "USER_DEFINED_ERROR",
                WorkflowExecutionEventErrorCode.WorkflowCancelled => "WORKFLOW_CANCELLED",
                WorkflowExecutionEventErrorCode.WorkflowInitialization => "WORKFLOW_INITIALIZATION",
                WorkflowExecutionEventErrorCode.WorkflowTimeout => "WORKFLOW_TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowExecutionEventErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "INTEGRATION_CREDENTIALS_UNAVAILABLE" => WorkflowExecutionEventErrorCode.IntegrationCredentialsUnavailable,
                "INTERNAL_SERVER_ERROR" => WorkflowExecutionEventErrorCode.InternalServerError,
                "INVALID_INPUTS" => WorkflowExecutionEventErrorCode.InvalidInputs,
                "INVALID_TEMPLATE" => WorkflowExecutionEventErrorCode.InvalidTemplate,
                "LLM_PROVIDER" => WorkflowExecutionEventErrorCode.LlmProvider,
                "NODE_CANCELLED" => WorkflowExecutionEventErrorCode.NodeCancelled,
                "NODE_EXECUTION" => WorkflowExecutionEventErrorCode.NodeExecution,
                "NODE_EXECUTION_COUNT_LIMIT_REACHED" => WorkflowExecutionEventErrorCode.NodeExecutionCountLimitReached,
                "NODE_TIMEOUT" => WorkflowExecutionEventErrorCode.NodeTimeout,
                "PROVIDER_CREDENTIALS_UNAVAILABLE" => WorkflowExecutionEventErrorCode.ProviderCredentialsUnavailable,
                "PROVIDER_QUOTA_EXCEEDED" => WorkflowExecutionEventErrorCode.ProviderQuotaExceeded,
                "USER_DEFINED_ERROR" => WorkflowExecutionEventErrorCode.UserDefinedError,
                "WORKFLOW_CANCELLED" => WorkflowExecutionEventErrorCode.WorkflowCancelled,
                "WORKFLOW_INITIALIZATION" => WorkflowExecutionEventErrorCode.WorkflowInitialization,
                "WORKFLOW_TIMEOUT" => WorkflowExecutionEventErrorCode.WorkflowTimeout,
                _ => null,
            };
        }
    }
}