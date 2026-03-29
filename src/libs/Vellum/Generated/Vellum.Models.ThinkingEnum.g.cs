
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum ThinkingEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThinkingEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThinkingEnum value)
        {
            return value switch
            {
                ThinkingEnum.Thinking => "THINKING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThinkingEnum? ToEnum(string value)
        {
            return value switch
            {
                "THINKING" => ThinkingEnum.Thinking,
                _ => null,
            };
        }
    }
}