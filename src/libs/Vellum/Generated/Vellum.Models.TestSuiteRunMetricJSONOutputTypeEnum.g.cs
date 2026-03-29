
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `JSON` - JSON
    /// </summary>
    public enum TestSuiteRunMetricJSONOutputTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunMetricJSONOutputTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunMetricJSONOutputTypeEnum value)
        {
            return value switch
            {
                TestSuiteRunMetricJSONOutputTypeEnum.Json => "JSON",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunMetricJSONOutputTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "JSON" => TestSuiteRunMetricJSONOutputTypeEnum.Json,
                _ => null,
            };
        }
    }
}