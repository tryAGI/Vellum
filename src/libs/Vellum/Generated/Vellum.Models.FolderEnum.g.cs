
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum FolderEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Folder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FolderEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FolderEnum value)
        {
            return value switch
            {
                FolderEnum.Folder => "FOLDER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FolderEnum? ToEnum(string value)
        {
            return value switch
            {
                "FOLDER" => FolderEnum.Folder,
                _ => null,
            };
        }
    }
}