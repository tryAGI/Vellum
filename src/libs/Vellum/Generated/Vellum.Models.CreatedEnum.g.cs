
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatedEnum value)
        {
            return value switch
            {
                CreatedEnum.Created => "CREATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatedEnum? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => CreatedEnum.Created,
                _ => null,
            };
        }
    }
}