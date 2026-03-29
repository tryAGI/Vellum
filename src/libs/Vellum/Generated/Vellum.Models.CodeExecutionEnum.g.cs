
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeExecutionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecution,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeExecutionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeExecutionEnum value)
        {
            return value switch
            {
                CodeExecutionEnum.CodeExecution => "CODE_EXECUTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeExecutionEnum? ToEnum(string value)
        {
            return value switch
            {
                "CODE_EXECUTION" => CodeExecutionEnum.CodeExecution,
                _ => null,
            };
        }
    }
}