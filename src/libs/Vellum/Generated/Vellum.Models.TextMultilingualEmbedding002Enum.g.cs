
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextMultilingualEmbedding002Enum
    {
        /// <summary>
        /// 
        /// </summary>
        TextMultilingualEmbedding002,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextMultilingualEmbedding002EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextMultilingualEmbedding002Enum value)
        {
            return value switch
            {
                TextMultilingualEmbedding002Enum.TextMultilingualEmbedding002 => "text-multilingual-embedding-002",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextMultilingualEmbedding002Enum? ToEnum(string value)
        {
            return value switch
            {
                "text-multilingual-embedding-002" => TextMultilingualEmbedding002Enum.TextMultilingualEmbedding002,
                _ => null,
            };
        }
    }
}