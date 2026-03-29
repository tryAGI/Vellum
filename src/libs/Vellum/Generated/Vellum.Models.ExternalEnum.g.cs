
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExternalEnum
    {
        /// <summary>
        /// 
        /// </summary>
        External,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalEnum value)
        {
            return value switch
            {
                ExternalEnum.External => "EXTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalEnum? ToEnum(string value)
        {
            return value switch
            {
                "EXTERNAL" => ExternalEnum.External,
                _ => null,
            };
        }
    }
}