
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchResultsEnum
    {
        /// <summary>
        /// 
        /// </summary>
        SearchResults,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchResultsEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResultsEnum value)
        {
            return value switch
            {
                SearchResultsEnum.SearchResults => "SEARCH_RESULTS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResultsEnum? ToEnum(string value)
        {
            return value switch
            {
                "SEARCH_RESULTS" => SearchResultsEnum.SearchResults,
                _ => null,
            };
        }
    }
}