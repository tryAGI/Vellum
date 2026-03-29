
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum SentenceTransformersMultiQaMpnetBaseCosV1Enum
    {
        /// <summary>
        /// 
        /// </summary>
        SentenceTransformersMultiQaMpnetBaseCosV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SentenceTransformersMultiQaMpnetBaseCosV1EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SentenceTransformersMultiQaMpnetBaseCosV1Enum value)
        {
            return value switch
            {
                SentenceTransformersMultiQaMpnetBaseCosV1Enum.SentenceTransformersMultiQaMpnetBaseCosV1 => "sentence-transformers/multi-qa-mpnet-base-cos-v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SentenceTransformersMultiQaMpnetBaseCosV1Enum? ToEnum(string value)
        {
            return value switch
            {
                "sentence-transformers/multi-qa-mpnet-base-cos-v1" => SentenceTransformersMultiQaMpnetBaseCosV1Enum.SentenceTransformersMultiQaMpnetBaseCosV1,
                _ => null,
            };
        }
    }
}