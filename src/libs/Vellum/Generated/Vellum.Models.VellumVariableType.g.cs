
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `STRING` - STRING<br/>
    /// * `NUMBER` - NUMBER<br/>
    /// * `JSON` - JSON<br/>
    /// * `CHAT_HISTORY` - CHAT_HISTORY<br/>
    /// * `SEARCH_RESULTS` - SEARCH_RESULTS<br/>
    /// * `ERROR` - ERROR<br/>
    /// * `ARRAY` - ARRAY<br/>
    /// * `FUNCTION_CALL` - FUNCTION_CALL<br/>
    /// * `AUDIO` - AUDIO<br/>
    /// * `VIDEO` - VIDEO<br/>
    /// * `IMAGE` - IMAGE<br/>
    /// * `DOCUMENT` - DOCUMENT<br/>
    /// * `NULL` - NULL<br/>
    /// * `THINKING` - THINKING<br/>
    /// * `REFERENCE` - REFERENCE
    /// </summary>
    public enum VellumVariableType
    {
        /// <summary>
        /// 
        /// </summary>
        Array,
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        ChatHistory,
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Null,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Reference,
        /// <summary>
        /// 
        /// </summary>
        SearchResults,
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VellumVariableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VellumVariableType value)
        {
            return value switch
            {
                VellumVariableType.Array => "ARRAY",
                VellumVariableType.Audio => "AUDIO",
                VellumVariableType.ChatHistory => "CHAT_HISTORY",
                VellumVariableType.Document => "DOCUMENT",
                VellumVariableType.Error => "ERROR",
                VellumVariableType.FunctionCall => "FUNCTION_CALL",
                VellumVariableType.Image => "IMAGE",
                VellumVariableType.Json => "JSON",
                VellumVariableType.Null => "NULL",
                VellumVariableType.Number => "NUMBER",
                VellumVariableType.Reference => "REFERENCE",
                VellumVariableType.SearchResults => "SEARCH_RESULTS",
                VellumVariableType.String => "STRING",
                VellumVariableType.Thinking => "THINKING",
                VellumVariableType.Video => "VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VellumVariableType? ToEnum(string value)
        {
            return value switch
            {
                "ARRAY" => VellumVariableType.Array,
                "AUDIO" => VellumVariableType.Audio,
                "CHAT_HISTORY" => VellumVariableType.ChatHistory,
                "DOCUMENT" => VellumVariableType.Document,
                "ERROR" => VellumVariableType.Error,
                "FUNCTION_CALL" => VellumVariableType.FunctionCall,
                "IMAGE" => VellumVariableType.Image,
                "JSON" => VellumVariableType.Json,
                "NULL" => VellumVariableType.Null,
                "NUMBER" => VellumVariableType.Number,
                "REFERENCE" => VellumVariableType.Reference,
                "SEARCH_RESULTS" => VellumVariableType.SearchResults,
                "STRING" => VellumVariableType.String,
                "THINKING" => VellumVariableType.Thinking,
                "VIDEO" => VellumVariableType.Video,
                _ => null,
            };
        }
    }
}