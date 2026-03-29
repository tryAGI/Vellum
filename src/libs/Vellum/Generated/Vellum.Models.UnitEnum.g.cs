
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `USD` - USD
    /// </summary>
    public enum UnitEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnitEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnitEnum value)
        {
            return value switch
            {
                UnitEnum.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnitEnum? ToEnum(string value)
        {
            return value switch
            {
                "USD" => UnitEnum.Usd,
                _ => null,
            };
        }
    }
}