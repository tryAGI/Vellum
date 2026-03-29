
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `ANONYMOUS` - ANONYMOUS<br/>
    /// * `WORKSPACE_API_KEY` - WORKSPACE_API_KEY<br/>
    /// * `ENVIRONMENT_API_KEY` - ENVIRONMENT_API_KEY<br/>
    /// * `JWT` - JWT<br/>
    /// * `SERVICE_TOKEN` - SERVICE_TOKEN
    /// </summary>
    public enum ApiActorTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Anonymous,
        /// <summary>
        /// 
        /// </summary>
        EnvironmentApiKey,
        /// <summary>
        /// 
        /// </summary>
        Jwt,
        /// <summary>
        /// 
        /// </summary>
        ServiceToken,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiActorTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiActorTypeEnum value)
        {
            return value switch
            {
                ApiActorTypeEnum.Anonymous => "ANONYMOUS",
                ApiActorTypeEnum.EnvironmentApiKey => "ENVIRONMENT_API_KEY",
                ApiActorTypeEnum.Jwt => "JWT",
                ApiActorTypeEnum.ServiceToken => "SERVICE_TOKEN",
                ApiActorTypeEnum.WorkspaceApiKey => "WORKSPACE_API_KEY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiActorTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "ANONYMOUS" => ApiActorTypeEnum.Anonymous,
                "ENVIRONMENT_API_KEY" => ApiActorTypeEnum.EnvironmentApiKey,
                "JWT" => ApiActorTypeEnum.Jwt,
                "SERVICE_TOKEN" => ApiActorTypeEnum.ServiceToken,
                "WORKSPACE_API_KEY" => ApiActorTypeEnum.WorkspaceApiKey,
                _ => null,
            };
        }
    }
}