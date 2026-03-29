
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `WORKFLOW_RELEASE_TAG` - WORKFLOW_RELEASE_TAG
    /// </summary>
    public enum TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowReleaseTag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunWorkflowReleaseTagExecConfigTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum value)
        {
            return value switch
            {
                TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum.WorkflowReleaseTag => "WORKFLOW_RELEASE_TAG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "WORKFLOW_RELEASE_TAG" => TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum.WorkflowReleaseTag,
                _ => null,
            };
        }
    }
}