
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `WORKFLOW_SANDBOX` - WORKFLOW_SANDBOX
    /// </summary>
    public enum TestSuiteRunWorkflowSandboxExecConfigTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowSandbox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunWorkflowSandboxExecConfigTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunWorkflowSandboxExecConfigTypeEnum value)
        {
            return value switch
            {
                TestSuiteRunWorkflowSandboxExecConfigTypeEnum.WorkflowSandbox => "WORKFLOW_SANDBOX",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunWorkflowSandboxExecConfigTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "WORKFLOW_SANDBOX" => TestSuiteRunWorkflowSandboxExecConfigTypeEnum.WorkflowSandbox,
                _ => null,
            };
        }
    }
}