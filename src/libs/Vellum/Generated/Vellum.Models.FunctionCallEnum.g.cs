
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionCallEnum
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionCallEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallEnum value)
        {
            return value switch
            {
                FunctionCallEnum.FunctionCall => "FUNCTION_CALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallEnum? ToEnum(string value)
        {
            return value switch
            {
                "FUNCTION_CALL" => FunctionCallEnum.FunctionCall,
                _ => null,
            };
        }
    }
}