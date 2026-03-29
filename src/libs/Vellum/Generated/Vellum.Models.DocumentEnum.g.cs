
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum DocumentEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentEnum value)
        {
            return value switch
            {
                DocumentEnum.Document => "DOCUMENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentEnum? ToEnum(string value)
        {
            return value switch
            {
                "DOCUMENT" => DocumentEnum.Document,
                _ => null,
            };
        }
    }
}