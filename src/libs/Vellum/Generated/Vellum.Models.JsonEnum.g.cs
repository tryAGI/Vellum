
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum JsonEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JsonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JsonEnum value)
        {
            return value switch
            {
                JsonEnum.Json => "JSON",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JsonEnum? ToEnum(string value)
        {
            return value switch
            {
                "JSON" => JsonEnum.Json,
                _ => null,
            };
        }
    }
}