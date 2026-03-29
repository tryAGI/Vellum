
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `INITIATED` - Initiated<br/>
    /// * `STREAMING` - Streaming<br/>
    /// * `FULFILLED` - Fulfilled<br/>
    /// * `REJECTED` - Rejected<br/>
    /// * `PENDING` - Pending
    /// </summary>
    public enum WorkflowResultEventState
    {
        /// <summary>
        /// 
        /// </summary>
        Fulfilled,
        /// <summary>
        /// 
        /// </summary>
        Initiated,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Streaming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowResultEventStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowResultEventState value)
        {
            return value switch
            {
                WorkflowResultEventState.Fulfilled => "FULFILLED",
                WorkflowResultEventState.Initiated => "INITIATED",
                WorkflowResultEventState.Pending => "PENDING",
                WorkflowResultEventState.Rejected => "REJECTED",
                WorkflowResultEventState.Streaming => "STREAMING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowResultEventState? ToEnum(string value)
        {
            return value switch
            {
                "FULFILLED" => WorkflowResultEventState.Fulfilled,
                "INITIATED" => WorkflowResultEventState.Initiated,
                "PENDING" => WorkflowResultEventState.Pending,
                "REJECTED" => WorkflowResultEventState.Rejected,
                "STREAMING" => WorkflowResultEventState.Streaming,
                _ => null,
            };
        }
    }
}