
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum StringEnum
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StringEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StringEnum value)
        {
            return value switch
            {
                StringEnum.String => "STRING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StringEnum? ToEnum(string value)
        {
            return value switch
            {
                "STRING" => StringEnum.String,
                _ => null,
            };
        }
    }
}