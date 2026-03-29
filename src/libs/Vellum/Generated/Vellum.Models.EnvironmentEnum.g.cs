
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnvironmentEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Development,
        /// <summary>
        /// 
        /// </summary>
        Production,
        /// <summary>
        /// 
        /// </summary>
        Staging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentEnum value)
        {
            return value switch
            {
                EnvironmentEnum.Development => "DEVELOPMENT",
                EnvironmentEnum.Production => "PRODUCTION",
                EnvironmentEnum.Staging => "STAGING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentEnum? ToEnum(string value)
        {
            return value switch
            {
                "DEVELOPMENT" => EnvironmentEnum.Development,
                "PRODUCTION" => EnvironmentEnum.Production,
                "STAGING" => EnvironmentEnum.Staging,
                _ => null,
            };
        }
    }
}