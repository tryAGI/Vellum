
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum TokenOverlappingWindowChunkerEnum
    {
        /// <summary>
        /// 
        /// </summary>
        TokenOverlappingWindowChunker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenOverlappingWindowChunkerEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenOverlappingWindowChunkerEnum value)
        {
            return value switch
            {
                TokenOverlappingWindowChunkerEnum.TokenOverlappingWindowChunker => "token-overlapping-window-chunker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenOverlappingWindowChunkerEnum? ToEnum(string value)
        {
            return value switch
            {
                "token-overlapping-window-chunker" => TokenOverlappingWindowChunkerEnum.TokenOverlappingWindowChunker,
                _ => null,
            };
        }
    }
}