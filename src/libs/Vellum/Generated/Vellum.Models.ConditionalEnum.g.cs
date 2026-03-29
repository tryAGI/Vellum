
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConditionalEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Conditional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConditionalEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConditionalEnum value)
        {
            return value switch
            {
                ConditionalEnum.Conditional => "CONDITIONAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConditionalEnum? ToEnum(string value)
        {
            return value switch
            {
                "CONDITIONAL" => ConditionalEnum.Conditional,
                _ => null,
            };
        }
    }
}