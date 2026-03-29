
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `INITIATED` - INITIATED<br/>
    /// * `STREAMING` - STREAMING<br/>
    /// * `FULFILLED` - FULFILLED<br/>
    /// * `REJECTED` - REJECTED
    /// </summary>
    public enum WorkflowNodeResultEventState
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
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Streaming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowNodeResultEventStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowNodeResultEventState value)
        {
            return value switch
            {
                WorkflowNodeResultEventState.Fulfilled => "FULFILLED",
                WorkflowNodeResultEventState.Initiated => "INITIATED",
                WorkflowNodeResultEventState.Rejected => "REJECTED",
                WorkflowNodeResultEventState.Streaming => "STREAMING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowNodeResultEventState? ToEnum(string value)
        {
            return value switch
            {
                "FULFILLED" => WorkflowNodeResultEventState.Fulfilled,
                "INITIATED" => WorkflowNodeResultEventState.Initiated,
                "REJECTED" => WorkflowNodeResultEventState.Rejected,
                "STREAMING" => WorkflowNodeResultEventState.Streaming,
                _ => null,
            };
        }
    }
}