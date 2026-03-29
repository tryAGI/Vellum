
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `ARRAY` - ARRAY
    /// </summary>
    public enum TestSuiteRunMetricArrayOutputTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Array,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunMetricArrayOutputTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunMetricArrayOutputTypeEnum value)
        {
            return value switch
            {
                TestSuiteRunMetricArrayOutputTypeEnum.Array => "ARRAY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunMetricArrayOutputTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "ARRAY" => TestSuiteRunMetricArrayOutputTypeEnum.Array,
                _ => null,
            };
        }
    }
}