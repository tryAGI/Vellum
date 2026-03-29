
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowExecutionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowExecution,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowExecutionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowExecutionEnum value)
        {
            return value switch
            {
                WorkflowExecutionEnum.WorkflowExecution => "workflow.execution",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowExecutionEnum? ToEnum(string value)
        {
            return value switch
            {
                "workflow.execution" => WorkflowExecutionEnum.WorkflowExecution,
                _ => null,
            };
        }
    }
}