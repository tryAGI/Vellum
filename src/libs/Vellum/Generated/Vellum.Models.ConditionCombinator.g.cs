
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `OR` - OR<br/>
    /// * `AND` - AND
    /// </summary>
    public enum ConditionCombinator
    {
        /// <summary>
        /// 
        /// </summary>
        And,
        /// <summary>
        /// 
        /// </summary>
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConditionCombinatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConditionCombinator value)
        {
            return value switch
            {
                ConditionCombinator.And => "AND",
                ConditionCombinator.Or => "OR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConditionCombinator? ToEnum(string value)
        {
            return value switch
            {
                "AND" => ConditionCombinator.And,
                "OR" => ConditionCombinator.Or,
                _ => null,
            };
        }
    }
}