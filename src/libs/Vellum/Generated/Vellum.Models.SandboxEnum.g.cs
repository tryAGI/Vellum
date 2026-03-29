
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum SandboxEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Sandbox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxEnum value)
        {
            return value switch
            {
                SandboxEnum.Sandbox => "SANDBOX",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxEnum? ToEnum(string value)
        {
            return value switch
            {
                "SANDBOX" => SandboxEnum.Sandbox,
                _ => null,
            };
        }
    }
}