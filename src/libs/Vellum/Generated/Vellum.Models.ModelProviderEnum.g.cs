
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelProviderEnum
    {
        /// <summary>
        /// 
        /// </summary>
        ModelProvider,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelProviderEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelProviderEnum value)
        {
            return value switch
            {
                ModelProviderEnum.ModelProvider => "MODEL_PROVIDER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelProviderEnum? ToEnum(string value)
        {
            return value switch
            {
                "MODEL_PROVIDER" => ModelProviderEnum.ModelProvider,
                _ => null,
            };
        }
    }
}