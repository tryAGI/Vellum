
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptEnum value)
        {
            return value switch
            {
                PromptEnum.Prompt => "PROMPT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptEnum? ToEnum(string value)
        {
            return value switch
            {
                "PROMPT" => PromptEnum.Prompt,
                _ => null,
            };
        }
    }
}