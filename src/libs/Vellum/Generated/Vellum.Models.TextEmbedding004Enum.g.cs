
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextEmbedding004Enum
    {
        /// <summary>
        /// 
        /// </summary>
        TextEmbedding004,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEmbedding004EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEmbedding004Enum value)
        {
            return value switch
            {
                TextEmbedding004Enum.TextEmbedding004 => "text-embedding-004",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEmbedding004Enum? ToEnum(string value)
        {
            return value switch
            {
                "text-embedding-004" => TextEmbedding004Enum.TextEmbedding004,
                _ => null,
            };
        }
    }
}