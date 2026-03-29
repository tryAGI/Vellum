
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `EXCEEDED_CHARACTER_LIMIT` - Exceeded Character Limit<br/>
    /// * `INVALID_FILE` - Invalid File<br/>
    /// * `INVALID_CREDENTIALS` - Invalid Credentials
    /// </summary>
    public enum ProcessingFailureReasonEnum
    {
        /// <summary>
        /// 
        /// </summary>
        ExceededCharacterLimit,
        /// <summary>
        /// 
        /// </summary>
        InvalidCredentials,
        /// <summary>
        /// 
        /// </summary>
        InvalidFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingFailureReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingFailureReasonEnum value)
        {
            return value switch
            {
                ProcessingFailureReasonEnum.ExceededCharacterLimit => "EXCEEDED_CHARACTER_LIMIT",
                ProcessingFailureReasonEnum.InvalidCredentials => "INVALID_CREDENTIALS",
                ProcessingFailureReasonEnum.InvalidFile => "INVALID_FILE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingFailureReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "EXCEEDED_CHARACTER_LIMIT" => ProcessingFailureReasonEnum.ExceededCharacterLimit,
                "INVALID_CREDENTIALS" => ProcessingFailureReasonEnum.InvalidCredentials,
                "INVALID_FILE" => ProcessingFailureReasonEnum.InvalidFile,
                _ => null,
            };
        }
    }
}