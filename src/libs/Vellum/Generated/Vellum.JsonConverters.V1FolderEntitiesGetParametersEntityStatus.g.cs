#nullable enable

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public sealed class V1FolderEntitiesGetParametersEntityStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.V1FolderEntitiesGetParametersEntityStatus>
    {
        /// <inheritdoc />
        public override global::Vellum.V1FolderEntitiesGetParametersEntityStatus Read(
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
                        return global::Vellum.V1FolderEntitiesGetParametersEntityStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vellum.V1FolderEntitiesGetParametersEntityStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vellum.V1FolderEntitiesGetParametersEntityStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.V1FolderEntitiesGetParametersEntityStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vellum.V1FolderEntitiesGetParametersEntityStatusExtensions.ToValueString(value));
        }
    }
}
