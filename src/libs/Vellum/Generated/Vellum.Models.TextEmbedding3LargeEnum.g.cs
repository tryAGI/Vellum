
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextEmbedding3LargeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        TextEmbedding3Large,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEmbedding3LargeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEmbedding3LargeEnum value)
        {
            return value switch
            {
                TextEmbedding3LargeEnum.TextEmbedding3Large => "text-embedding-3-large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEmbedding3LargeEnum? ToEnum(string value)
        {
            return value switch
            {
                "text-embedding-3-large" => TextEmbedding3LargeEnum.TextEmbedding3Large,
                _ => null,
            };
        }
    }
}