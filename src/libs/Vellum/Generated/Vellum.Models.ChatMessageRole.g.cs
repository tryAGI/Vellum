
#nullable enable

namespace Vellum
{
    /// <summary>
    /// * `SYSTEM` - System<br/>
    /// * `ASSISTANT` - Assistant<br/>
    /// * `USER` - User<br/>
    /// * `FUNCTION` - Function
    /// </summary>
    public enum ChatMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageRole value)
        {
            return value switch
            {
                ChatMessageRole.Assistant => "ASSISTANT",
                ChatMessageRole.Function => "FUNCTION",
                ChatMessageRole.System => "SYSTEM",
                ChatMessageRole.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "ASSISTANT" => ChatMessageRole.Assistant,
                "FUNCTION" => ChatMessageRole.Function,
                "SYSTEM" => ChatMessageRole.System,
                "USER" => ChatMessageRole.User,
                _ => null,
            };
        }
    }
}