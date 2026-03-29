
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum RejectedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RejectedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RejectedEnum value)
        {
            return value switch
            {
                RejectedEnum.Rejected => "REJECTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RejectedEnum? ToEnum(string value)
        {
            return value switch
            {
                "REJECTED" => RejectedEnum.Rejected,
                _ => null,
            };
        }
    }
}