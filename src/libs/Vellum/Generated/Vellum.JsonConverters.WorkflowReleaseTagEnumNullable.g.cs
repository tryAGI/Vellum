#nullable enable

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public sealed class WorkflowReleaseTagEnumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.WorkflowReleaseTagEnum?>
    {
        /// <inheritdoc />
        public override global::Vellum.WorkflowReleaseTagEnum? Read(
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
                        return global::Vellum.WorkflowReleaseTagEnumExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vellum.WorkflowReleaseTagEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vellum.WorkflowReleaseTagEnum?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.WorkflowReleaseTagEnum? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vellum.WorkflowReleaseTagEnumExtensions.ToValueString(value.Value));
            }
        }
    }
}
