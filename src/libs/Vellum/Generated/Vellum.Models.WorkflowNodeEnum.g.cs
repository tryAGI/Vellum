
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowNodeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowNode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowNodeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowNodeEnum value)
        {
            return value switch
            {
                WorkflowNodeEnum.WorkflowNode => "WORKFLOW_NODE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowNodeEnum? ToEnum(string value)
        {
            return value switch
            {
                "WORKFLOW_NODE" => WorkflowNodeEnum.WorkflowNode,
                _ => null,
            };
        }
    }
}