
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `EPHEMERAL` - EPHEMERAL
    /// </summary>
    public enum EphemeralPromptCacheConfigTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EphemeralPromptCacheConfigTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EphemeralPromptCacheConfigTypeEnum value)
        {
            return value switch
            {
                EphemeralPromptCacheConfigTypeEnum.Ephemeral => "EPHEMERAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EphemeralPromptCacheConfigTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "EPHEMERAL" => EphemeralPromptCacheConfigTypeEnum.Ephemeral,
                _ => null,
            };
        }
    }
}