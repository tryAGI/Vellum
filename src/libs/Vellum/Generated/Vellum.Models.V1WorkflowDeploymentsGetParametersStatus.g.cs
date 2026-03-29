
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1WorkflowDeploymentsGetParametersStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        PendingDeletion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1WorkflowDeploymentsGetParametersStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1WorkflowDeploymentsGetParametersStatus value)
        {
            return value switch
            {
                V1WorkflowDeploymentsGetParametersStatus.Active => "ACTIVE",
                V1WorkflowDeploymentsGetParametersStatus.Archived => "ARCHIVED",
                V1WorkflowDeploymentsGetParametersStatus.PendingDeletion => "PENDING_DELETION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1WorkflowDeploymentsGetParametersStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => V1WorkflowDeploymentsGetParametersStatus.Active,
                "ARCHIVED" => V1WorkflowDeploymentsGetParametersStatus.Archived,
                "PENDING_DELETION" => V1WorkflowDeploymentsGetParametersStatus.PendingDeletion,
                _ => null,
            };
        }
    }
}