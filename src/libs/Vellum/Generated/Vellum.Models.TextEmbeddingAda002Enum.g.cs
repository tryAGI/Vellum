
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextEmbeddingAda002Enum
    {
        /// <summary>
        /// 
        /// </summary>
        TextEmbeddingAda002,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEmbeddingAda002EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEmbeddingAda002Enum value)
        {
            return value switch
            {
                TextEmbeddingAda002Enum.TextEmbeddingAda002 => "text-embedding-ada-002",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEmbeddingAda002Enum? ToEnum(string value)
        {
            return value switch
            {
                "text-embedding-ada-002" => TextEmbeddingAda002Enum.TextEmbeddingAda002,
                _ => null,
            };
        }
    }
}