
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptReleaseTagEnum
    {
        /// <summary>
        /// 
        /// </summary>
        PromptReleaseTag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptReleaseTagEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptReleaseTagEnum value)
        {
            return value switch
            {
                PromptReleaseTagEnum.PromptReleaseTag => "PROMPT_RELEASE_TAG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptReleaseTagEnum? ToEnum(string value)
        {
            return value switch
            {
                "PROMPT_RELEASE_TAG" => PromptReleaseTagEnum.PromptReleaseTag,
                _ => null,
            };
        }
    }
}