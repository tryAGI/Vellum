
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum InitiatedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Initiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InitiatedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InitiatedEnum value)
        {
            return value switch
            {
                InitiatedEnum.Initiated => "INITIATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InitiatedEnum? ToEnum(string value)
        {
            return value switch
            {
                "INITIATED" => InitiatedEnum.Initiated,
                _ => null,
            };
        }
    }
}