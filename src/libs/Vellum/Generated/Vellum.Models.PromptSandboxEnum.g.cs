
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptSandboxEnum
    {
        /// <summary>
        /// 
        /// </summary>
        PromptSandbox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptSandboxEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptSandboxEnum value)
        {
            return value switch
            {
                PromptSandboxEnum.PromptSandbox => "PROMPT_SANDBOX",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptSandboxEnum? ToEnum(string value)
        {
            return value switch
            {
                "PROMPT_SANDBOX" => PromptSandboxEnum.PromptSandbox,
                _ => null,
            };
        }
    }
}