
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum NodeExecutionFulfilledEnum
    {
        /// <summary>
        /// 
        /// </summary>
        NodeExecutionFulfilled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeExecutionFulfilledEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeExecutionFulfilledEnum value)
        {
            return value switch
            {
                NodeExecutionFulfilledEnum.NodeExecutionFulfilled => "node.execution.fulfilled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeExecutionFulfilledEnum? ToEnum(string value)
        {
            return value switch
            {
                "node.execution.fulfilled" => NodeExecutionFulfilledEnum.NodeExecutionFulfilled,
                _ => null,
            };
        }
    }
}