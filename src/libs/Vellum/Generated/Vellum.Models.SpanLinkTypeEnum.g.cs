
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `TRIGGERED_BY` - TRIGGERED_BY<br/>
    /// * `PREVIOUS_SPAN` - PREVIOUS_SPAN<br/>
    /// * `ROOT_SPAN` - ROOT_SPAN
    /// </summary>
    public enum SpanLinkTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        PreviousSpan,
        /// <summary>
        /// 
        /// </summary>
        RootSpan,
        /// <summary>
        /// 
        /// </summary>
        TriggeredBy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpanLinkTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanLinkTypeEnum value)
        {
            return value switch
            {
                SpanLinkTypeEnum.PreviousSpan => "PREVIOUS_SPAN",
                SpanLinkTypeEnum.RootSpan => "ROOT_SPAN",
                SpanLinkTypeEnum.TriggeredBy => "TRIGGERED_BY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanLinkTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "PREVIOUS_SPAN" => SpanLinkTypeEnum.PreviousSpan,
                "ROOT_SPAN" => SpanLinkTypeEnum.RootSpan,
                "TRIGGERED_BY" => SpanLinkTypeEnum.TriggeredBy,
                _ => null,
            };
        }
    }
}