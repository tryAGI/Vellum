
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum TerminalEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Terminal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TerminalEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TerminalEnum value)
        {
            return value switch
            {
                TerminalEnum.Terminal => "TERMINAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TerminalEnum? ToEnum(string value)
        {
            return value switch
            {
                "TERMINAL" => TerminalEnum.Terminal,
                _ => null,
            };
        }
    }
}