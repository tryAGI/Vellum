
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `ACTIVE` - Active
    /// </summary>
    public enum DocumentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentStatus value)
        {
            return value switch
            {
                DocumentStatus.Active => "ACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => DocumentStatus.Active,
                _ => null,
            };
        }
    }
}