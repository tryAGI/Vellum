
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `AWAITING_PROCESSING` - Awaiting Processing<br/>
    /// * `QUEUED` - Queued<br/>
    /// * `INDEXING` - Indexing<br/>
    /// * `INDEXED` - Indexed<br/>
    /// * `FAILED` - Failed
    /// </summary>
    public enum IndexingStateEnum
    {
        /// <summary>
        /// 
        /// </summary>
        AwaitingProcessing,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Indexed,
        /// <summary>
        /// 
        /// </summary>
        Indexing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IndexingStateEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IndexingStateEnum value)
        {
            return value switch
            {
                IndexingStateEnum.AwaitingProcessing => "AWAITING_PROCESSING",
                IndexingStateEnum.Failed => "FAILED",
                IndexingStateEnum.Indexed => "INDEXED",
                IndexingStateEnum.Indexing => "INDEXING",
                IndexingStateEnum.Queued => "QUEUED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IndexingStateEnum? ToEnum(string value)
        {
            return value switch
            {
                "AWAITING_PROCESSING" => IndexingStateEnum.AwaitingProcessing,
                "FAILED" => IndexingStateEnum.Failed,
                "INDEXED" => IndexingStateEnum.Indexed,
                "INDEXING" => IndexingStateEnum.Indexing,
                "QUEUED" => IndexingStateEnum.Queued,
                _ => null,
            };
        }
    }
}