
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum DocumentIndexEnum
    {
        /// <summary>
        /// 
        /// </summary>
        DocumentIndex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentIndexEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentIndexEnum value)
        {
            return value switch
            {
                DocumentIndexEnum.DocumentIndex => "DOCUMENT_INDEX",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentIndexEnum? ToEnum(string value)
        {
            return value switch
            {
                "DOCUMENT_INDEX" => DocumentIndexEnum.DocumentIndex,
                _ => null,
            };
        }
    }
}