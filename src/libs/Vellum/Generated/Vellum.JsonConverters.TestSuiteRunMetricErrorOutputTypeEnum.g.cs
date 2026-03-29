#nullable enable

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public sealed class TestSuiteRunMetricErrorOutputTypeEnumJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum>
    {
        /// <inheritdoc />
        public override global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum Read(
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
                        return global::Vellum.TestSuiteRunMetricErrorOutputTypeEnumExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vellum.TestSuiteRunMetricErrorOutputTypeEnumExtensions.ToValueString(value));
        }
    }
}
