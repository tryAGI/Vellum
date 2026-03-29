
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `NUMBER` - NUMBER
    /// </summary>
    public enum TestSuiteRunMetricNumberOutputTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunMetricNumberOutputTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunMetricNumberOutputTypeEnum value)
        {
            return value switch
            {
                TestSuiteRunMetricNumberOutputTypeEnum.Number => "NUMBER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunMetricNumberOutputTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "NUMBER" => TestSuiteRunMetricNumberOutputTypeEnum.Number,
                _ => null,
            };
        }
    }
}