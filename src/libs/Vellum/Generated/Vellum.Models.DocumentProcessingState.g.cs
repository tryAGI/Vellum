
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `QUEUED` - Queued<br/>
    /// * `PROCESSING` - Processing<br/>
    /// * `PROCESSED` - Processed<br/>
    /// * `FAILED` - Failed<br/>
    /// * `UNKNOWN` - Unknown
    /// </summary>
    public enum DocumentProcessingState
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentProcessingStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentProcessingState value)
        {
            return value switch
            {
                DocumentProcessingState.Failed => "FAILED",
                DocumentProcessingState.Processed => "PROCESSED",
                DocumentProcessingState.Processing => "PROCESSING",
                DocumentProcessingState.Queued => "QUEUED",
                DocumentProcessingState.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentProcessingState? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => DocumentProcessingState.Failed,
                "PROCESSED" => DocumentProcessingState.Processed,
                "PROCESSING" => DocumentProcessingState.Processing,
                "QUEUED" => DocumentProcessingState.Queued,
                "UNKNOWN" => DocumentProcessingState.Unknown,
                _ => null,
            };
        }
    }
}