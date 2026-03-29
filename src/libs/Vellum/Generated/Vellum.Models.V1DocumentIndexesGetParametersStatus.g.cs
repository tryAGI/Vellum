
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1DocumentIndexesGetParametersStatus
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
    public static class V1DocumentIndexesGetParametersStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1DocumentIndexesGetParametersStatus value)
        {
            return value switch
            {
                V1DocumentIndexesGetParametersStatus.Active => "ACTIVE",
                V1DocumentIndexesGetParametersStatus.Archived => "ARCHIVED",
                V1DocumentIndexesGetParametersStatus.PendingDeletion => "PENDING_DELETION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1DocumentIndexesGetParametersStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => V1DocumentIndexesGetParametersStatus.Active,
                "ARCHIVED" => V1DocumentIndexesGetParametersStatus.Archived,
                "PENDING_DELETION" => V1DocumentIndexesGetParametersStatus.PendingDeletion,
                _ => null,
            };
        }
    }
}