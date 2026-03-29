
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum MergeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Merge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MergeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MergeEnum value)
        {
            return value switch
            {
                MergeEnum.Merge => "MERGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MergeEnum? ToEnum(string value)
        {
            return value switch
            {
                "MERGE" => MergeEnum.Merge,
                _ => null,
            };
        }
    }
}