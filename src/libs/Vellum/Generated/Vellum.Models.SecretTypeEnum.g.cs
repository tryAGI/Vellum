
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `USER_DEFINED` - User Defined<br/>
    /// * `HMAC` - Hmac<br/>
    /// * `INTERNAL_API_KEY` - Internal Api Key<br/>
    /// * `EXTERNALLY_PROVISIONED` - Externally Provisioned
    /// </summary>
    public enum SecretTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        ExternallyProvisioned,
        /// <summary>
        /// 
        /// </summary>
        Hmac,
        /// <summary>
        /// 
        /// </summary>
        InternalApiKey,
        /// <summary>
        /// 
        /// </summary>
        UserDefined,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretTypeEnum value)
        {
            return value switch
            {
                SecretTypeEnum.ExternallyProvisioned => "EXTERNALLY_PROVISIONED",
                SecretTypeEnum.Hmac => "HMAC",
                SecretTypeEnum.InternalApiKey => "INTERNAL_API_KEY",
                SecretTypeEnum.UserDefined => "USER_DEFINED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "EXTERNALLY_PROVISIONED" => SecretTypeEnum.ExternallyProvisioned,
                "HMAC" => SecretTypeEnum.Hmac,
                "INTERNAL_API_KEY" => SecretTypeEnum.InternalApiKey,
                "USER_DEFINED" => SecretTypeEnum.UserDefined,
                _ => null,
            };
        }
    }
}