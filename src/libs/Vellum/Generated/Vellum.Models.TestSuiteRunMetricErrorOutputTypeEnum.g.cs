
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `ERROR` - ERROR
    /// </summary>
    public enum TestSuiteRunMetricErrorOutputTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunMetricErrorOutputTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunMetricErrorOutputTypeEnum value)
        {
            return value switch
            {
                TestSuiteRunMetricErrorOutputTypeEnum.Error => "ERROR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunMetricErrorOutputTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => TestSuiteRunMetricErrorOutputTypeEnum.Error,
                _ => null,
            };
        }
    }
}