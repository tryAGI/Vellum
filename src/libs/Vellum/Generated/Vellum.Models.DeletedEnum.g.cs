
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeletedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletedEnum value)
        {
            return value switch
            {
                DeletedEnum.Deleted => "DELETED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletedEnum? ToEnum(string value)
        {
            return value switch
            {
                "DELETED" => DeletedEnum.Deleted,
                _ => null,
            };
        }
    }
}