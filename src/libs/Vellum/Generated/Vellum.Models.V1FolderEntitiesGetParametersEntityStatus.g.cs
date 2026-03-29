
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1FolderEntitiesGetParametersEntityStatus
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
    public static class V1FolderEntitiesGetParametersEntityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1FolderEntitiesGetParametersEntityStatus value)
        {
            return value switch
            {
                V1FolderEntitiesGetParametersEntityStatus.Active => "ACTIVE",
                V1FolderEntitiesGetParametersEntityStatus.Archived => "ARCHIVED",
                V1FolderEntitiesGetParametersEntityStatus.PendingDeletion => "PENDING_DELETION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1FolderEntitiesGetParametersEntityStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => V1FolderEntitiesGetParametersEntityStatus.Active,
                "ARCHIVED" => V1FolderEntitiesGetParametersEntityStatus.Archived,
                "PENDING_DELETION" => V1FolderEntitiesGetParametersEntityStatus.PendingDeletion,
                _ => null,
            };
        }
    }
}