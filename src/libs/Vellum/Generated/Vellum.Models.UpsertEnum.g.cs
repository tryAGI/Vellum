
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpsertEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Upsert,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpsertEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpsertEnum value)
        {
            return value switch
            {
                UpsertEnum.Upsert => "UPSERT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpsertEnum? ToEnum(string value)
        {
            return value switch
            {
                "UPSERT" => UpsertEnum.Upsert,
                _ => null,
            };
        }
    }
}