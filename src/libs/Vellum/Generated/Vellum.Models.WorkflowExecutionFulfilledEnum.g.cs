
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowExecutionFulfilledEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowExecutionFulfilled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowExecutionFulfilledEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowExecutionFulfilledEnum value)
        {
            return value switch
            {
                WorkflowExecutionFulfilledEnum.WorkflowExecutionFulfilled => "workflow.execution.fulfilled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowExecutionFulfilledEnum? ToEnum(string value)
        {
            return value switch
            {
                "workflow.execution.fulfilled" => WorkflowExecutionFulfilledEnum.WorkflowExecutionFulfilled,
                _ => null,
            };
        }
    }
}