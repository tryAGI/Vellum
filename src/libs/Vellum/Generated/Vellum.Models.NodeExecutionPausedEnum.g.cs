
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum NodeExecutionPausedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        NodeExecutionPaused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeExecutionPausedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeExecutionPausedEnum value)
        {
            return value switch
            {
                NodeExecutionPausedEnum.NodeExecutionPaused => "node.execution.paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeExecutionPausedEnum? ToEnum(string value)
        {
            return value switch
            {
                "node.execution.paused" => NodeExecutionPausedEnum.NodeExecutionPaused,
                _ => null,
            };
        }
    }
}