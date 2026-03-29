
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum IntegrationEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationEnum value)
        {
            return value switch
            {
                IntegrationEnum.Integration => "INTEGRATION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationEnum? ToEnum(string value)
        {
            return value switch
            {
                "INTEGRATION" => IntegrationEnum.Integration,
                _ => null,
            };
        }
    }
}