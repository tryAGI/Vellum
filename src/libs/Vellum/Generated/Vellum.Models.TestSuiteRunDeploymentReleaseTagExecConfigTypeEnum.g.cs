
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `DEPLOYMENT_RELEASE_TAG` - DEPLOYMENT_RELEASE_TAG
    /// </summary>
    public enum TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        DeploymentReleaseTag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteRunDeploymentReleaseTagExecConfigTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum value)
        {
            return value switch
            {
                TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum.DeploymentReleaseTag => "DEPLOYMENT_RELEASE_TAG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "DEPLOYMENT_RELEASE_TAG" => TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum.DeploymentReleaseTag,
                _ => null,
            };
        }
    }
}