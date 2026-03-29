
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowEnum value)
        {
            return value switch
            {
                WorkflowEnum.Workflow => "WORKFLOW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowEnum? ToEnum(string value)
        {
            return value switch
            {
                "WORKFLOW" => WorkflowEnum.Workflow,
                _ => null,
            };
        }
    }
}