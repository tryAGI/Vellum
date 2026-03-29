
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum FulfilledEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Fulfilled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FulfilledEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FulfilledEnum value)
        {
            return value switch
            {
                FulfilledEnum.Fulfilled => "FULFILLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FulfilledEnum? ToEnum(string value)
        {
            return value switch
            {
                "FULFILLED" => FulfilledEnum.Fulfilled,
                _ => null,
            };
        }
    }
}