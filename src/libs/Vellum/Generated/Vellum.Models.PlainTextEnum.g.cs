
#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public enum PlainTextEnum
    {
        /// <summary>
        ///
        /// </summary>
        PlainText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlainTextEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlainTextEnum value)
        {
            return value switch
            {
                PlainTextEnum.PlainText => "PLAIN_TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlainTextEnum? ToEnum(string value)
        {
            return value switch
            {
                "PLAIN_TEXT" => PlainTextEnum.PlainText,
                _ => null,
            };
        }
    }
}