
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowExecutionResumedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowExecutionResumed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowExecutionResumedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowExecutionResumedEnum value)
        {
            return value switch
            {
                WorkflowExecutionResumedEnum.WorkflowExecutionResumed => "workflow.execution.resumed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowExecutionResumedEnum? ToEnum(string value)
        {
            return value switch
            {
                "workflow.execution.resumed" => WorkflowExecutionResumedEnum.WorkflowExecutionResumed,
                _ => null,
            };
        }
    }
}