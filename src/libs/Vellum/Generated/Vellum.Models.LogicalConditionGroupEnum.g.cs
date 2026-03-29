
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum LogicalConditionGroupEnum
    {
        /// <summary>
        /// 
        /// </summary>
        LogicalConditionGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogicalConditionGroupEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogicalConditionGroupEnum value)
        {
            return value switch
            {
                LogicalConditionGroupEnum.LogicalConditionGroup => "LOGICAL_CONDITION_GROUP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogicalConditionGroupEnum? ToEnum(string value)
        {
            return value switch
            {
                "LOGICAL_CONDITION_GROUP" => LogicalConditionGroupEnum.LogicalConditionGroup,
                _ => null,
            };
        }
    }
}