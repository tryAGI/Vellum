
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `DEBUG` - DEBUG<br/>
    /// * `INFO` - INFO<br/>
    /// * `WARNING` - WARNING<br/>
    /// * `ERROR` - ERROR
    /// </summary>
    public enum SeverityEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Debug,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SeverityEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SeverityEnum value)
        {
            return value switch
            {
                SeverityEnum.Debug => "DEBUG",
                SeverityEnum.Error => "ERROR",
                SeverityEnum.Info => "INFO",
                SeverityEnum.Warning => "WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SeverityEnum? ToEnum(string value)
        {
            return value switch
            {
                "DEBUG" => SeverityEnum.Debug,
                "ERROR" => SeverityEnum.Error,
                "INFO" => SeverityEnum.Info,
                "WARNING" => SeverityEnum.Warning,
                _ => null,
            };
        }
    }
}