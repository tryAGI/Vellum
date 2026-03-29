
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowExecutionRejectedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowExecutionRejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowExecutionRejectedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowExecutionRejectedEnum value)
        {
            return value switch
            {
                WorkflowExecutionRejectedEnum.WorkflowExecutionRejected => "workflow.execution.rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowExecutionRejectedEnum? ToEnum(string value)
        {
            return value switch
            {
                "workflow.execution.rejected" => WorkflowExecutionRejectedEnum.WorkflowExecutionRejected,
                _ => null,
            };
        }
    }
}