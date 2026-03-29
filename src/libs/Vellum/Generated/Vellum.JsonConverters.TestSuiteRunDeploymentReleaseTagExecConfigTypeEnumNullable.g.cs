#nullable enable

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public sealed class TestSuiteRunDeploymentReleaseTagExecConfigTypeEnumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum?>
    {
        /// <inheritdoc />
        public override global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum? Read(
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
                        return global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnumExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnumExtensions.ToValueString(value.Value));
            }
        }
    }
}
