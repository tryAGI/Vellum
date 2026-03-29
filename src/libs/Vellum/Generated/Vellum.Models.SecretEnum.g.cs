
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecretEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretEnum value)
        {
            return value switch
            {
                SecretEnum.Secret => "SECRET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretEnum? ToEnum(string value)
        {
            return value switch
            {
                "SECRET" => SecretEnum.Secret,
                _ => null,
            };
        }
    }
}