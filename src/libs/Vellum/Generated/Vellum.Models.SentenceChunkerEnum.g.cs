
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum SentenceChunkerEnum
    {
        /// <summary>
        /// 
        /// </summary>
        SentenceChunker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SentenceChunkerEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SentenceChunkerEnum value)
        {
            return value switch
            {
                SentenceChunkerEnum.SentenceChunker => "sentence-chunker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SentenceChunkerEnum? ToEnum(string value)
        {
            return value switch
            {
                "sentence-chunker" => SentenceChunkerEnum.SentenceChunker,
                _ => null,
            };
        }
    }
}