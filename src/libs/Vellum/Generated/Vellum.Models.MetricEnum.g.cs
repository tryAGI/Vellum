
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetricEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Metric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetricEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetricEnum value)
        {
            return value switch
            {
                MetricEnum.Metric => "METRIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetricEnum? ToEnum(string value)
        {
            return value switch
            {
                "METRIC" => MetricEnum.Metric,
                _ => null,
            };
        }
    }
}