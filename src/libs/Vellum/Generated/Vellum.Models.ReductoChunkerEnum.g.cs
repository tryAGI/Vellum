
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReductoChunkerEnum
    {
        /// <summary>
        /// 
        /// </summary>
        ReductoChunker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReductoChunkerEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReductoChunkerEnum value)
        {
            return value switch
            {
                ReductoChunkerEnum.ReductoChunker => "reducto-chunker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReductoChunkerEnum? ToEnum(string value)
        {
            return value switch
            {
                "reducto-chunker" => ReductoChunkerEnum.ReductoChunker,
                _ => null,
            };
        }
    }
}