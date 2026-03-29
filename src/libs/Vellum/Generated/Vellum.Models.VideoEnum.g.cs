
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoEnum value)
        {
            return value switch
            {
                VideoEnum.Video => "VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoEnum? ToEnum(string value)
        {
            return value switch
            {
                "VIDEO" => VideoEnum.Video,
                _ => null,
            };
        }
    }
}