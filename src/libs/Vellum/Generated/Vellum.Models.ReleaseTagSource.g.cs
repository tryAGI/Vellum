
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `SYSTEM` - System<br/>
    /// * `USER` - User
    /// </summary>
    public enum ReleaseTagSource
    {
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReleaseTagSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReleaseTagSource value)
        {
            return value switch
            {
                ReleaseTagSource.System => "SYSTEM",
                ReleaseTagSource.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReleaseTagSource? ToEnum(string value)
        {
            return value switch
            {
                "SYSTEM" => ReleaseTagSource.System,
                "USER" => ReleaseTagSource.User,
                _ => null,
            };
        }
    }
}