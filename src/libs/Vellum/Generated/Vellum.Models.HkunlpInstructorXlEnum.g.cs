
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum HkunlpInstructorXlEnum
    {
        /// <summary>
        /// 
        /// </summary>
        HkunlpInstructorXl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HkunlpInstructorXlEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HkunlpInstructorXlEnum value)
        {
            return value switch
            {
                HkunlpInstructorXlEnum.HkunlpInstructorXl => "hkunlp/instructor-xl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HkunlpInstructorXlEnum? ToEnum(string value)
        {
            return value switch
            {
                "hkunlp/instructor-xl" => HkunlpInstructorXlEnum.HkunlpInstructorXl,
                _ => null,
            };
        }
    }
}