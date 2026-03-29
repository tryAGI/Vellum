
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaaiBgeSmallEnV15Enum
    {
        /// <summary>
        /// 
        /// </summary>
        BaaiBgeSmallEnV15,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaaiBgeSmallEnV15EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaaiBgeSmallEnV15Enum value)
        {
            return value switch
            {
                BaaiBgeSmallEnV15Enum.BaaiBgeSmallEnV15 => "BAAI/bge-small-en-v1.5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaaiBgeSmallEnV15Enum? ToEnum(string value)
        {
            return value switch
            {
                "BAAI/bge-small-en-v1.5" => BaaiBgeSmallEnV15Enum.BaaiBgeSmallEnV15,
                _ => null,
            };
        }
    }
}