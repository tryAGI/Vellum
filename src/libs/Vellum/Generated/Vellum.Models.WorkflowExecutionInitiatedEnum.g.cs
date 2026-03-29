
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowExecutionInitiatedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowExecutionInitiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowExecutionInitiatedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowExecutionInitiatedEnum value)
        {
            return value switch
            {
                WorkflowExecutionInitiatedEnum.WorkflowExecutionInitiated => "workflow.execution.initiated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowExecutionInitiatedEnum? ToEnum(string value)
        {
            return value switch
            {
                "workflow.execution.initiated" => WorkflowExecutionInitiatedEnum.WorkflowExecutionInitiated,
                _ => null,
            };
        }
    }
}