
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `2024-10-25` - V2024_10_25<br/>
    /// * `2025-07-30` - V2025_07_30
    /// </summary>
    public enum ApiVersionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        x20241025,
        /// <summary>
        /// 
        /// </summary>
        x20250730,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiVersionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiVersionEnum value)
        {
            return value switch
            {
                ApiVersionEnum.x20241025 => "2024-10-25",
                ApiVersionEnum.x20250730 => "2025-07-30",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiVersionEnum? ToEnum(string value)
        {
            return value switch
            {
                "2024-10-25" => ApiVersionEnum.x20241025,
                "2025-07-30" => ApiVersionEnum.x20250730,
                _ => null,
            };
        }
    }
}