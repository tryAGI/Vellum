
#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatMessageEnum
    {
        /// <summary>
        ///
        /// </summary>
        ChatMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageEnum value)
        {
            return value switch
            {
                ChatMessageEnum.ChatMessage => "CHAT_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageEnum? ToEnum(string value)
        {
            return value switch
            {
                "CHAT_MESSAGE" => ChatMessageEnum.ChatMessage,
                _ => null,
            };
        }
    }
}