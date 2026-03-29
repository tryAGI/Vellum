
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `APPROVED` - Approved<br/>
    /// * `CHANGES_REQUESTED` - Changes Requested<br/>
    /// * `COMMENTED` - Commented
    /// </summary>
    public enum ReleaseReviewState
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        ChangesRequested,
        /// <summary>
        /// 
        /// </summary>
        Commented,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReleaseReviewStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReleaseReviewState value)
        {
            return value switch
            {
                ReleaseReviewState.Approved => "APPROVED",
                ReleaseReviewState.ChangesRequested => "CHANGES_REQUESTED",
                ReleaseReviewState.Commented => "COMMENTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReleaseReviewState? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => ReleaseReviewState.Approved,
                "CHANGES_REQUESTED" => ReleaseReviewState.ChangesRequested,
                "COMMENTED" => ReleaseReviewState.Commented,
                _ => null,
            };
        }
    }
}