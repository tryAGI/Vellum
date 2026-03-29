
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum NodeExecutionInitiatedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        NodeExecutionInitiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeExecutionInitiatedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeExecutionInitiatedEnum value)
        {
            return value switch
            {
                NodeExecutionInitiatedEnum.NodeExecutionInitiated => "node.execution.initiated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeExecutionInitiatedEnum? ToEnum(string value)
        {
            return value switch
            {
                "node.execution.initiated" => NodeExecutionInitiatedEnum.NodeExecutionInitiated,
                _ => null,
            };
        }
    }
}