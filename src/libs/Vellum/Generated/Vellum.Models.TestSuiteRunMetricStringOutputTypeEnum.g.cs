
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `STRING` - STRING
    /// </summary>
    public enum TestSuiteRunMetricStringOutputTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunMetricStringOutputTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunMetricStringOutputTypeEnum value)
        {
            return value switch
            {
                TestSuiteRunMetricStringOutputTypeEnum.String => "STRING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunMetricStringOutputTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "STRING" => TestSuiteRunMetricStringOutputTypeEnum.String,
                _ => null,
            };
        }
    }
}