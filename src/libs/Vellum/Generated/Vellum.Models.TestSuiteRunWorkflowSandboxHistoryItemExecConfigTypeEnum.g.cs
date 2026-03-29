
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `WORKFLOW_SANDBOX_HISTORY_ITEM` - WORKFLOW_SANDBOX_HISTORY_ITEM
    /// </summary>
    public enum TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowSandboxHistoryItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum value)
        {
            return value switch
            {
                TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum.WorkflowSandboxHistoryItem => "WORKFLOW_SANDBOX_HISTORY_ITEM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "WORKFLOW_SANDBOX_HISTORY_ITEM" => TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum.WorkflowSandboxHistoryItem,
                _ => null,
            };
        }
    }
}