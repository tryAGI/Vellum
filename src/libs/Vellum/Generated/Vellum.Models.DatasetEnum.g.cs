
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum DatasetEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Dataset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetEnum value)
        {
            return value switch
            {
                DatasetEnum.Dataset => "DATASET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetEnum? ToEnum(string value)
        {
            return value switch
            {
                "DATASET" => DatasetEnum.Dataset,
                _ => null,
            };
        }
    }
}