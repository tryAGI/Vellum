
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum ArrayEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Array,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArrayEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArrayEnum value)
        {
            return value switch
            {
                ArrayEnum.Array => "ARRAY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArrayEnum? ToEnum(string value)
        {
            return value switch
            {
                "ARRAY" => ArrayEnum.Array,
                _ => null,
            };
        }
    }
}