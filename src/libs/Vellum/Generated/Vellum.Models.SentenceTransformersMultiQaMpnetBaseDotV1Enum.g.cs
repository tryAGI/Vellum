
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum SentenceTransformersMultiQaMpnetBaseDotV1Enum
    {
        /// <summary>
        /// 
        /// </summary>
        SentenceTransformersMultiQaMpnetBaseDotV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SentenceTransformersMultiQaMpnetBaseDotV1EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SentenceTransformersMultiQaMpnetBaseDotV1Enum value)
        {
            return value switch
            {
                SentenceTransformersMultiQaMpnetBaseDotV1Enum.SentenceTransformersMultiQaMpnetBaseDotV1 => "sentence-transformers/multi-qa-mpnet-base-dot-v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SentenceTransformersMultiQaMpnetBaseDotV1Enum? ToEnum(string value)
        {
            return value switch
            {
                "sentence-transformers/multi-qa-mpnet-base-dot-v1" => SentenceTransformersMultiQaMpnetBaseDotV1Enum.SentenceTransformersMultiQaMpnetBaseDotV1,
                _ => null,
            };
        }
    }
}