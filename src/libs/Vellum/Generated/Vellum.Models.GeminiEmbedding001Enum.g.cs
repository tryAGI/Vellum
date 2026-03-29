
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeminiEmbedding001Enum
    {
        /// <summary>
        /// 
        /// </summary>
        GeminiEmbedding001,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeminiEmbedding001EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeminiEmbedding001Enum value)
        {
            return value switch
            {
                GeminiEmbedding001Enum.GeminiEmbedding001 => "gemini-embedding-001",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeminiEmbedding001Enum? ToEnum(string value)
        {
            return value switch
            {
                "gemini-embedding-001" => GeminiEmbedding001Enum.GeminiEmbedding001,
                _ => null,
            };
        }
    }
}