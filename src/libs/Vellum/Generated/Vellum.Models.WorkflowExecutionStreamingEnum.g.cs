
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowExecutionStreamingEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowExecutionStreaming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowExecutionStreamingEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowExecutionStreamingEnum value)
        {
            return value switch
            {
                WorkflowExecutionStreamingEnum.WorkflowExecutionStreaming => "workflow.execution.streaming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowExecutionStreamingEnum? ToEnum(string value)
        {
            return value switch
            {
                "workflow.execution.streaming" => WorkflowExecutionStreamingEnum.WorkflowExecutionStreaming,
                _ => null,
            };
        }
    }
}