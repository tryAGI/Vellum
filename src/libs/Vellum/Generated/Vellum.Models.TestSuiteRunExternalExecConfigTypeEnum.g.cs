
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `EXTERNAL` - EXTERNAL
    /// </summary>
    public enum TestSuiteRunExternalExecConfigTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        External,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunExternalExecConfigTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunExternalExecConfigTypeEnum value)
        {
            return value switch
            {
                TestSuiteRunExternalExecConfigTypeEnum.External => "EXTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunExternalExecConfigTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "EXTERNAL" => TestSuiteRunExternalExecConfigTypeEnum.External,
                _ => null,
            };
        }
    }
}