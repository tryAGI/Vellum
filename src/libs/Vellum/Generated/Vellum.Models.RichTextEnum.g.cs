
#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public enum RichTextEnum
    {
        /// <summary>
        ///
        /// </summary>
        RichText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichTextEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichTextEnum value)
        {
            return value switch
            {
                RichTextEnum.RichText => "RICH_TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichTextEnum? ToEnum(string value)
        {
            return value switch
            {
                "RICH_TEXT" => RichTextEnum.RichText,
                _ => null,
            };
        }
    }
}