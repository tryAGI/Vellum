
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `QUEUED` - Queued<br/>
    /// * `RUNNING` - Running<br/>
    /// * `COMPLETE` - Complete<br/>
    /// * `FAILED` - Failed<br/>
    /// * `CANCELLED` - Cancelled
    /// </summary>
    public enum TestSuiteRunState
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunState value)
        {
            return value switch
            {
                TestSuiteRunState.Cancelled => "CANCELLED",
                TestSuiteRunState.Complete => "COMPLETE",
                TestSuiteRunState.Failed => "FAILED",
                TestSuiteRunState.Queued => "QUEUED",
                TestSuiteRunState.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunState? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => TestSuiteRunState.Cancelled,
                "COMPLETE" => TestSuiteRunState.Complete,
                "FAILED" => TestSuiteRunState.Failed,
                "QUEUED" => TestSuiteRunState.Queued,
                "RUNNING" => TestSuiteRunState.Running,
                _ => null,
            };
        }
    }
}