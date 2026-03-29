
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioEnum value)
        {
            return value switch
            {
                AudioEnum.Audio => "AUDIO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioEnum? ToEnum(string value)
        {
            return value switch
            {
                "AUDIO" => AudioEnum.Audio,
                _ => null,
            };
        }
    }
}