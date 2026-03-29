
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum NodeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Node,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeEnum value)
        {
            return value switch
            {
                NodeEnum.Node => "NODE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeEnum? ToEnum(string value)
        {
            return value switch
            {
                "NODE" => NodeEnum.Node,
                _ => null,
            };
        }
    }
}