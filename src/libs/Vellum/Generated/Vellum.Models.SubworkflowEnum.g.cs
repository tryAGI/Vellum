
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubworkflowEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Subworkflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubworkflowEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubworkflowEnum value)
        {
            return value switch
            {
                SubworkflowEnum.Subworkflow => "SUBWORKFLOW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubworkflowEnum? ToEnum(string value)
        {
            return value switch
            {
                "SUBWORKFLOW" => SubworkflowEnum.Subworkflow,
                _ => null,
            };
        }
    }
}