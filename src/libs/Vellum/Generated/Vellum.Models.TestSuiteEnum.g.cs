
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestSuiteEnum
    {
        /// <summary>
        /// 
        /// </summary>
        TestSuite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteEnum value)
        {
            return value switch
            {
                TestSuiteEnum.TestSuite => "TEST_SUITE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteEnum? ToEnum(string value)
        {
            return value switch
            {
                "TEST_SUITE" => TestSuiteEnum.TestSuite,
                _ => null,
            };
        }
    }
}