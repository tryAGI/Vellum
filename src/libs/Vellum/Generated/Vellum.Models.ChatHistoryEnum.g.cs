
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatHistoryEnum
    {
        /// <summary>
        /// 
        /// </summary>
        ChatHistory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatHistoryEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatHistoryEnum value)
        {
            return value switch
            {
                ChatHistoryEnum.ChatHistory => "CHAT_HISTORY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatHistoryEnum? ToEnum(string value)
        {
            return value switch
            {
                "CHAT_HISTORY" => ChatHistoryEnum.ChatHistory,
                _ => null,
            };
        }
    }
}