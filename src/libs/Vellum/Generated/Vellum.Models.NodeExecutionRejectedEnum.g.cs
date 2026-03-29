
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum NodeExecutionRejectedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        NodeExecutionRejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeExecutionRejectedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeExecutionRejectedEnum value)
        {
            return value switch
            {
                NodeExecutionRejectedEnum.NodeExecutionRejected => "node.execution.rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeExecutionRejectedEnum? ToEnum(string value)
        {
            return value switch
            {
                "node.execution.rejected" => NodeExecutionRejectedEnum.NodeExecutionRejected,
                _ => null,
            };
        }
    }
}