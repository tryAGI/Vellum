
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `ACTIVE` - Active<br/>
    /// * `ARCHIVED` - Archived<br/>
    /// * `PENDING_DELETION` - Pending Deletion
    /// </summary>
    public enum EntityStatus
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
    public static class EntityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntityStatus value)
        {
            return value switch
            {
                EntityStatus.Active => "ACTIVE",
                EntityStatus.Archived => "ARCHIVED",
                EntityStatus.PendingDeletion => "PENDING_DELETION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntityStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => EntityStatus.Active,
                "ARCHIVED" => EntityStatus.Archived,
                "PENDING_DELETION" => EntityStatus.PendingDeletion,
                _ => null,
            };
        }
    }
}