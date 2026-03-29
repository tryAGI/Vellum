#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class PromptOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.PromptOutput>
    {
        /// <inheritdoc />
        public override global::Vellum.PromptOutput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Vellum.StringVellumValue? stringVellumValue = default;
            global::Vellum.JsonVellumValue? jsonVellumValue = default;
            global::Vellum.ErrorVellumValue? errorVellumValue = default;
            global::Vellum.FunctionCallVellumValue? functionCallVellumValue = default;
            global::Vellum.ThinkingVellumValue? thinkingVellumValue = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringVellumValue).Name}");
                        stringVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.JsonVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.JsonVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.JsonVellumValue).Name}");
                        jsonVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ErrorVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ErrorVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ErrorVellumValue).Name}");
                        errorVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallVellumValue).Name}");
                        functionCallVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ThinkingVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ThinkingVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ThinkingVellumValue).Name}");
                        thinkingVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (stringVellumValue == null && jsonVellumValue == null && errorVellumValue == null && functionCallVellumValue == null && thinkingVellumValue == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringVellumValue).Name}");
                    stringVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.JsonVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.JsonVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.JsonVellumValue).Name}");
                    jsonVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ErrorVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ErrorVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ErrorVellumValue).Name}");
                    errorVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallVellumValue).Name}");
                    functionCallVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ThinkingVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ThinkingVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ThinkingVellumValue).Name}");
                    thinkingVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.PromptOutput(
                stringVellumValue,

                jsonVellumValue,

                errorVellumValue,

                functionCallVellumValue,

                thinkingVellumValue
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.PromptOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStringVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringVellumValue, typeInfo);
            }
            else if (value.IsJsonVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.JsonVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.JsonVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.JsonVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonVellumValue, typeInfo);
            }
            else if (value.IsErrorVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ErrorVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ErrorVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ErrorVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ErrorVellumValue, typeInfo);
            }
            else if (value.IsFunctionCallVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallVellumValue, typeInfo);
            }
            else if (value.IsThinkingVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ThinkingVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ThinkingVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ThinkingVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingVellumValue, typeInfo);
            }
        }
    }
}