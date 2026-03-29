#nullable enable

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public sealed class IntfloatMultilingualE5LargeEnumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.IntfloatMultilingualE5LargeEnum?>
    {
        /// <inheritdoc />
        public override global::Vellum.IntfloatMultilingualE5LargeEnum? Read(
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
                        return global::Vellum.IntfloatMultilingualE5LargeEnumExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vellum.IntfloatMultilingualE5LargeEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vellum.IntfloatMultilingualE5LargeEnum?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.IntfloatMultilingualE5LargeEnum? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vellum.IntfloatMultilingualE5LargeEnumExtensions.ToValueString(value.Value));
            }
        }
    }
}
