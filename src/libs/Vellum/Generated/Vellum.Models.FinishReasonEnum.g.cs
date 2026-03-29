
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `LENGTH` - LENGTH<br/>
    /// * `STOP` - STOP<br/>
    /// * `UNKNOWN` - UNKNOWN
    /// </summary>
    public enum FinishReasonEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinishReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinishReasonEnum value)
        {
            return value switch
            {
                FinishReasonEnum.Length => "LENGTH",
                FinishReasonEnum.Stop => "STOP",
                FinishReasonEnum.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinishReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "LENGTH" => FinishReasonEnum.Length,
                "STOP" => FinishReasonEnum.Stop,
                "UNKNOWN" => FinishReasonEnum.Unknown,
                _ => null,
            };
        }
    }
}