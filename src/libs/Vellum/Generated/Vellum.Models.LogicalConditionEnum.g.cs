
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum LogicalConditionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        LogicalCondition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogicalConditionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogicalConditionEnum value)
        {
            return value switch
            {
                LogicalConditionEnum.LogicalCondition => "LOGICAL_CONDITION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogicalConditionEnum? ToEnum(string value)
        {
            return value switch
            {
                "LOGICAL_CONDITION" => LogicalConditionEnum.LogicalCondition,
                _ => null,
            };
        }
    }
}