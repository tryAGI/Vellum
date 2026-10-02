
#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public enum JinjaEnum
    {
        /// <summary>
        ///
        /// </summary>
        Jinja,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JinjaEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JinjaEnum value)
        {
            return value switch
            {
                JinjaEnum.Jinja => "JINJA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JinjaEnum? ToEnum(string value)
        {
            return value switch
            {
                "JINJA" => JinjaEnum.Jinja,
                _ => null,
            };
        }
    }
}