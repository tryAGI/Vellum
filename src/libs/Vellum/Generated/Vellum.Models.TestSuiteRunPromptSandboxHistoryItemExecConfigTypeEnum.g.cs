
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `PROMPT_SANDBOX_HISTORY_ITEM` - PROMPT_SANDBOX_HISTORY_ITEM
    /// </summary>
    public enum TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        PromptSandboxHistoryItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum value)
        {
            return value switch
            {
                TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum.PromptSandboxHistoryItem => "PROMPT_SANDBOX_HISTORY_ITEM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "PROMPT_SANDBOX_HISTORY_ITEM" => TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum.PromptSandboxHistoryItem,
                _ => null,
            };
        }
    }
}