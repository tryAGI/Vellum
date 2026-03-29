
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextEmbedding3SmallEnum
    {
        /// <summary>
        /// 
        /// </summary>
        TextEmbedding3Small,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEmbedding3SmallEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEmbedding3SmallEnum value)
        {
            return value switch
            {
                TextEmbedding3SmallEnum.TextEmbedding3Small => "text-embedding-3-small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEmbedding3SmallEnum? ToEnum(string value)
        {
            return value switch
            {
                "text-embedding-3-small" => TextEmbedding3SmallEnum.TextEmbedding3Small,
                _ => null,
            };
        }
    }
}