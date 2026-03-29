#nullable enable

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextEmbedding3SmallEnumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.TextEmbedding3SmallEnum?>
    {
        /// <inheritdoc />
        public override global::Vellum.TextEmbedding3SmallEnum? Read(
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
                        return global::Vellum.TextEmbedding3SmallEnumExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vellum.TextEmbedding3SmallEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vellum.TextEmbedding3SmallEnum?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.TextEmbedding3SmallEnum? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vellum.TextEmbedding3SmallEnumExtensions.ToValueString(value.Value));
            }
        }
    }
}
