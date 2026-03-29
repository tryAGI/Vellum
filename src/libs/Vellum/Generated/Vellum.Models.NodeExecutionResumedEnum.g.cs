
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum NodeExecutionResumedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        NodeExecutionResumed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeExecutionResumedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeExecutionResumedEnum value)
        {
            return value switch
            {
                NodeExecutionResumedEnum.NodeExecutionResumed => "node.execution.resumed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeExecutionResumedEnum? ToEnum(string value)
        {
            return value switch
            {
                "node.execution.resumed" => NodeExecutionResumedEnum.NodeExecutionResumed,
                _ => null,
            };
        }
    }
}