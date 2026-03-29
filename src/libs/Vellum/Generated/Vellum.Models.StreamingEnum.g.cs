
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum StreamingEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Streaming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingEnum value)
        {
            return value switch
            {
                StreamingEnum.Streaming => "STREAMING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingEnum? ToEnum(string value)
        {
            return value switch
            {
                "STREAMING" => StreamingEnum.Streaming,
                _ => null,
            };
        }
    }
}