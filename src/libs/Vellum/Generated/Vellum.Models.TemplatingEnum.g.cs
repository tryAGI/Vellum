
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplatingEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Templating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatingEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatingEnum value)
        {
            return value switch
            {
                TemplatingEnum.Templating => "TEMPLATING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatingEnum? ToEnum(string value)
        {
            return value switch
            {
                "TEMPLATING" => TemplatingEnum.Templating,
                _ => null,
            };
        }
    }
}