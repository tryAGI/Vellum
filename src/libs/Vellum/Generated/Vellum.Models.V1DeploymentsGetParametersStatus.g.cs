
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1DeploymentsGetParametersStatus
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
    public static class V1DeploymentsGetParametersStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1DeploymentsGetParametersStatus value)
        {
            return value switch
            {
                V1DeploymentsGetParametersStatus.Active => "ACTIVE",
                V1DeploymentsGetParametersStatus.Archived => "ARCHIVED",
                V1DeploymentsGetParametersStatus.PendingDeletion => "PENDING_DELETION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1DeploymentsGetParametersStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => V1DeploymentsGetParametersStatus.Active,
                "ARCHIVED" => V1DeploymentsGetParametersStatus.Archived,
                "PENDING_DELETION" => V1DeploymentsGetParametersStatus.PendingDeletion,
                _ => null,
            };
        }
    }
}