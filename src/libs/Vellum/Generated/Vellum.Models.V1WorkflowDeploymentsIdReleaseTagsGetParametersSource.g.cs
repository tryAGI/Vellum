
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1WorkflowDeploymentsIdReleaseTagsGetParametersSource
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
    public static class V1WorkflowDeploymentsIdReleaseTagsGetParametersSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1WorkflowDeploymentsIdReleaseTagsGetParametersSource value)
        {
            return value switch
            {
                V1WorkflowDeploymentsIdReleaseTagsGetParametersSource.System => "SYSTEM",
                V1WorkflowDeploymentsIdReleaseTagsGetParametersSource.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1WorkflowDeploymentsIdReleaseTagsGetParametersSource? ToEnum(string value)
        {
            return value switch
            {
                "SYSTEM" => V1WorkflowDeploymentsIdReleaseTagsGetParametersSource.System,
                "USER" => V1WorkflowDeploymentsIdReleaseTagsGetParametersSource.User,
                _ => null,
            };
        }
    }
}