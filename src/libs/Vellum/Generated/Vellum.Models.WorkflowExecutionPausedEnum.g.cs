
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowExecutionPausedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowExecutionPaused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowExecutionPausedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowExecutionPausedEnum value)
        {
            return value switch
            {
                WorkflowExecutionPausedEnum.WorkflowExecutionPaused => "workflow.execution.paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowExecutionPausedEnum? ToEnum(string value)
        {
            return value switch
            {
                "workflow.execution.paused" => WorkflowExecutionPausedEnum.WorkflowExecutionPaused,
                _ => null,
            };
        }
    }
}