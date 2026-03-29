
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `UNKNOWN` - UNKNOWN<br/>
    /// * `DEPENDENCIES_FAILED` - DEPENDENCIES_FAILED<br/>
    /// * `NO_USAGE_CALCULATED` - NO_USAGE_CALCULATED<br/>
    /// * `INTERNAL_SERVER_ERROR` - INTERNAL_SERVER_ERROR
    /// </summary>
    public enum WorkflowExecutionUsageCalculationErrorCodeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        DependenciesFailed,
        /// <summary>
        /// 
        /// </summary>
        InternalServerError,
        /// <summary>
        /// 
        /// </summary>
        NoUsageCalculated,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowExecutionUsageCalculationErrorCodeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowExecutionUsageCalculationErrorCodeEnum value)
        {
            return value switch
            {
                WorkflowExecutionUsageCalculationErrorCodeEnum.DependenciesFailed => "DEPENDENCIES_FAILED",
                WorkflowExecutionUsageCalculationErrorCodeEnum.InternalServerError => "INTERNAL_SERVER_ERROR",
                WorkflowExecutionUsageCalculationErrorCodeEnum.NoUsageCalculated => "NO_USAGE_CALCULATED",
                WorkflowExecutionUsageCalculationErrorCodeEnum.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowExecutionUsageCalculationErrorCodeEnum? ToEnum(string value)
        {
            return value switch
            {
                "DEPENDENCIES_FAILED" => WorkflowExecutionUsageCalculationErrorCodeEnum.DependenciesFailed,
                "INTERNAL_SERVER_ERROR" => WorkflowExecutionUsageCalculationErrorCodeEnum.InternalServerError,
                "NO_USAGE_CALCULATED" => WorkflowExecutionUsageCalculationErrorCodeEnum.NoUsageCalculated,
                "UNKNOWN" => WorkflowExecutionUsageCalculationErrorCodeEnum.Unknown,
                _ => null,
            };
        }
    }
}