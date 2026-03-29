
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `PROMPT_SANDBOX` - PROMPT_SANDBOX
    /// </summary>
    public enum TestSuiteRunPromptSandboxExecConfigTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        PromptSandbox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunPromptSandboxExecConfigTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunPromptSandboxExecConfigTypeEnum value)
        {
            return value switch
            {
                TestSuiteRunPromptSandboxExecConfigTypeEnum.PromptSandbox => "PROMPT_SANDBOX",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunPromptSandboxExecConfigTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "PROMPT_SANDBOX" => TestSuiteRunPromptSandboxExecConfigTypeEnum.PromptSandbox,
                _ => null,
            };
        }
    }
}