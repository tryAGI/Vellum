
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowSandboxEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowSandbox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowSandboxEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowSandboxEnum value)
        {
            return value switch
            {
                WorkflowSandboxEnum.WorkflowSandbox => "WORKFLOW_SANDBOX",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowSandboxEnum? ToEnum(string value)
        {
            return value switch
            {
                "WORKFLOW_SANDBOX" => WorkflowSandboxEnum.WorkflowSandbox,
                _ => null,
            };
        }
    }
}