#nullable enable

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public sealed class NodeExecutionPausedEnumJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.NodeExecutionPausedEnum>
    {
        /// <inheritdoc />
        public override global::Vellum.NodeExecutionPausedEnum Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Vellum.NodeExecutionPausedEnumExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vellum.NodeExecutionPausedEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vellum.NodeExecutionPausedEnum);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.NodeExecutionPausedEnum value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vellum.NodeExecutionPausedEnumExtensions.ToValueString(value));
        }
    }
}
