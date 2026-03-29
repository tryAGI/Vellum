
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum PdfEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Pdf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PdfEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PdfEnum value)
        {
            return value switch
            {
                PdfEnum.Pdf => "PDF",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PdfEnum? ToEnum(string value)
        {
            return value switch
            {
                "PDF" => PdfEnum.Pdf,
                _ => null,
            };
        }
    }
}