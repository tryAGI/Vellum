
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowReleaseTagEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowReleaseTag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowReleaseTagEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowReleaseTagEnum value)
        {
            return value switch
            {
                WorkflowReleaseTagEnum.WorkflowReleaseTag => "WORKFLOW_RELEASE_TAG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowReleaseTagEnum? ToEnum(string value)
        {
            return value switch
            {
                "WORKFLOW_RELEASE_TAG" => WorkflowReleaseTagEnum.WorkflowReleaseTag,
                _ => null,
            };
        }
    }
}