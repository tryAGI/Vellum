
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduledEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledEnum value)
        {
            return value switch
            {
                ScheduledEnum.Scheduled => "SCHEDULED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledEnum? ToEnum(string value)
        {
            return value switch
            {
                "SCHEDULED" => ScheduledEnum.Scheduled,
                _ => null,
            };
        }
    }
}