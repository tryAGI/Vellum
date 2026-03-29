
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum MapEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Map,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MapEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MapEnum value)
        {
            return value switch
            {
                MapEnum.Map => "MAP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MapEnum? ToEnum(string value)
        {
            return value switch
            {
                "MAP" => MapEnum.Map,
                _ => null,
            };
        }
    }
}