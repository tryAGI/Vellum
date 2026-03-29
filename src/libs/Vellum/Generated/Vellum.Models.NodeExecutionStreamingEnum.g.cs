
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum NodeExecutionStreamingEnum
    {
        /// <summary>
        /// 
        /// </summary>
        NodeExecutionStreaming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeExecutionStreamingEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeExecutionStreamingEnum value)
        {
            return value switch
            {
                NodeExecutionStreamingEnum.NodeExecutionStreaming => "node.execution.streaming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeExecutionStreamingEnum? ToEnum(string value)
        {
            return value switch
            {
                "node.execution.streaming" => NodeExecutionStreamingEnum.NodeExecutionStreaming,
                _ => null,
            };
        }
    }
}