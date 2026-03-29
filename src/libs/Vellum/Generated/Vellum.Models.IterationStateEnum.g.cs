
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `INITIATED` - INITIATED<br/>
    /// * `FULFILLED` - FULFILLED<br/>
    /// * `REJECTED` - REJECTED
    /// </summary>
    public enum IterationStateEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Fulfilled,
        /// <summary>
        /// 
        /// </summary>
        Initiated,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IterationStateEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IterationStateEnum value)
        {
            return value switch
            {
                IterationStateEnum.Fulfilled => "FULFILLED",
                IterationStateEnum.Initiated => "INITIATED",
                IterationStateEnum.Rejected => "REJECTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IterationStateEnum? ToEnum(string value)
        {
            return value switch
            {
                "FULFILLED" => IterationStateEnum.Fulfilled,
                "INITIATED" => IterationStateEnum.Initiated,
                "REJECTED" => IterationStateEnum.Rejected,
                _ => null,
            };
        }
    }
}