
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowExecutionSnapshottedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowExecutionSnapshotted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowExecutionSnapshottedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowExecutionSnapshottedEnum value)
        {
            return value switch
            {
                WorkflowExecutionSnapshottedEnum.WorkflowExecutionSnapshotted => "workflow.execution.snapshotted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowExecutionSnapshottedEnum? ToEnum(string value)
        {
            return value switch
            {
                "workflow.execution.snapshotted" => WorkflowExecutionSnapshottedEnum.WorkflowExecutionSnapshotted,
                _ => null,
            };
        }
    }
}