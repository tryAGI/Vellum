
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEnum value)
        {
            return value switch
            {
                CreateEnum.Create => "CREATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEnum? ToEnum(string value)
        {
            return value switch
            {
                "CREATE" => CreateEnum.Create,
                _ => null,
            };
        }
    }
}