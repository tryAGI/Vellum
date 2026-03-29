
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum IntfloatMultilingualE5LargeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        IntfloatMultilingualE5Large,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntfloatMultilingualE5LargeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntfloatMultilingualE5LargeEnum value)
        {
            return value switch
            {
                IntfloatMultilingualE5LargeEnum.IntfloatMultilingualE5Large => "intfloat/multilingual-e5-large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntfloatMultilingualE5LargeEnum? ToEnum(string value)
        {
            return value switch
            {
                "intfloat/multilingual-e5-large" => IntfloatMultilingualE5LargeEnum.IntfloatMultilingualE5Large,
                _ => null,
            };
        }
    }
}