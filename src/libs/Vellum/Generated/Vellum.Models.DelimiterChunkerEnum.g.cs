
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum DelimiterChunkerEnum
    {
        /// <summary>
        /// 
        /// </summary>
        DelimiterChunker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DelimiterChunkerEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DelimiterChunkerEnum value)
        {
            return value switch
            {
                DelimiterChunkerEnum.DelimiterChunker => "delimiter-chunker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DelimiterChunkerEnum? ToEnum(string value)
        {
            return value switch
            {
                "delimiter-chunker" => DelimiterChunkerEnum.DelimiterChunker,
                _ => null,
            };
        }
    }
}