
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `NODE` - NODE<br/>
    /// * `WORKFLOW` - WORKFLOW
    /// </summary>
    public enum WorkflowExecutionEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Node,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowExecutionEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowExecutionEventType value)
        {
            return value switch
            {
                WorkflowExecutionEventType.Node => "NODE",
                WorkflowExecutionEventType.Workflow => "WORKFLOW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowExecutionEventType? ToEnum(string value)
        {
            return value switch
            {
                "NODE" => WorkflowExecutionEventType.Node,
                "WORKFLOW" => WorkflowExecutionEventType.Workflow,
                _ => null,
            };
        }
    }
}