
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum NodeExecutionLogEnum
    {
        /// <summary>
        /// 
        /// </summary>
        NodeExecutionLog,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeExecutionLogEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeExecutionLogEnum value)
        {
            return value switch
            {
                NodeExecutionLogEnum.NodeExecutionLog => "node.execution.log",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeExecutionLogEnum? ToEnum(string value)
        {
            return value switch
            {
                "node.execution.log" => NodeExecutionLogEnum.NodeExecutionLog,
                _ => null,
            };
        }
    }
}