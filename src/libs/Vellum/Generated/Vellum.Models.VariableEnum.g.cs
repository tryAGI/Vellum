
#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public enum VariableEnum
    {
        /// <summary>
        ///
        /// </summary>
        Variable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VariableEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VariableEnum value)
        {
            return value switch
            {
                VariableEnum.Variable => "VARIABLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VariableEnum? ToEnum(string value)
        {
            return value switch
            {
                "VARIABLE" => VariableEnum.Variable,
                _ => null,
            };
        }
    }
}