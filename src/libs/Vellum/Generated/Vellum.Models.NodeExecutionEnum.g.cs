
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum NodeExecutionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        NodeExecution,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeExecutionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeExecutionEnum value)
        {
            return value switch
            {
                NodeExecutionEnum.NodeExecution => "node.execution",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeExecutionEnum? ToEnum(string value)
        {
            return value switch
            {
                "node.execution" => NodeExecutionEnum.NodeExecution,
                _ => null,
            };
        }
    }
}