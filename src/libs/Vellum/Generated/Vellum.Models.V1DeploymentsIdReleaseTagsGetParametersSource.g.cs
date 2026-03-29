
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1DeploymentsIdReleaseTagsGetParametersSource
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
    public static class V1DeploymentsIdReleaseTagsGetParametersSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1DeploymentsIdReleaseTagsGetParametersSource value)
        {
            return value switch
            {
                V1DeploymentsIdReleaseTagsGetParametersSource.System => "SYSTEM",
                V1DeploymentsIdReleaseTagsGetParametersSource.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1DeploymentsIdReleaseTagsGetParametersSource? ToEnum(string value)
        {
            return value switch
            {
                "SYSTEM" => V1DeploymentsIdReleaseTagsGetParametersSource.System,
                "USER" => V1DeploymentsIdReleaseTagsGetParametersSource.User,
                _ => null,
            };
        }
    }
}