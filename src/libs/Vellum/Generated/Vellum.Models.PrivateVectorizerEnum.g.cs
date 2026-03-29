
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum PrivateVectorizerEnum
    {
        /// <summary>
        /// 
        /// </summary>
        PrivateVectorizer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrivateVectorizerEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateVectorizerEnum value)
        {
            return value switch
            {
                PrivateVectorizerEnum.PrivateVectorizer => "private-vectorizer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateVectorizerEnum? ToEnum(string value)
        {
            return value switch
            {
                "private-vectorizer" => PrivateVectorizerEnum.PrivateVectorizer,
                _ => null,
            };
        }
    }
}