
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `ENABLED` - Enabled<br/>
    /// * `DISABLED` - Disabled
    /// </summary>
    public enum PromptBlockState
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptBlockStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptBlockState value)
        {
            return value switch
            {
                PromptBlockState.Disabled => "DISABLED",
                PromptBlockState.Enabled => "ENABLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptBlockState? ToEnum(string value)
        {
            return value switch
            {
                "DISABLED" => PromptBlockState.Disabled,
                "ENABLED" => PromptBlockState.Enabled,
                _ => null,
            };
        }
    }
}