
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `and` - AND<br/>
    /// * `or` - OR
    /// </summary>
    public enum MetadataFilterRuleCombinator
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
    public static class MetadataFilterRuleCombinatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataFilterRuleCombinator value)
        {
            return value switch
            {
                MetadataFilterRuleCombinator.And => "and",
                MetadataFilterRuleCombinator.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataFilterRuleCombinator? ToEnum(string value)
        {
            return value switch
            {
                "and" => MetadataFilterRuleCombinator.And,
                "or" => MetadataFilterRuleCombinator.Or,
                _ => null,
            };
        }
    }
}