#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class NamedScenarioInputRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.NamedScenarioInputRequest>
    {
        /// <inheritdoc />
        public override global::Vellum.NamedScenarioInputRequest Read(
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
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("value")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("value")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::Vellum.NamedScenarioInputStringVariableValueRequest? namedScenarioInputStringVariableValueRequest = default;
            global::Vellum.NamedScenarioInputJsonVariableValueRequest? namedScenarioInputJsonVariableValueRequest = default;
            global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest? namedScenarioInputChatHistoryVariableValueRequest = default;
            global::Vellum.NamedScenarioInputAudioVariableValueRequest? namedScenarioInputAudioVariableValueRequest = default;
            global::Vellum.NamedScenarioInputVideoVariableValueRequest? namedScenarioInputVideoVariableValueRequest = default;
            global::Vellum.NamedScenarioInputImageVariableValueRequest? namedScenarioInputImageVariableValueRequest = default;
            global::Vellum.NamedScenarioInputDocumentVariableValueRequest? namedScenarioInputDocumentVariableValueRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputStringVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputStringVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputStringVariableValueRequest).Name}");
                        namedScenarioInputStringVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputJsonVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputJsonVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputJsonVariableValueRequest).Name}");
                        namedScenarioInputJsonVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest).Name}");
                        namedScenarioInputChatHistoryVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputAudioVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputAudioVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputAudioVariableValueRequest).Name}");
                        namedScenarioInputAudioVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputVideoVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputVideoVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputVideoVariableValueRequest).Name}");
                        namedScenarioInputVideoVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputImageVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputImageVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputImageVariableValueRequest).Name}");
                        namedScenarioInputImageVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputDocumentVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputDocumentVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputDocumentVariableValueRequest).Name}");
                        namedScenarioInputDocumentVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (namedScenarioInputStringVariableValueRequest == null && namedScenarioInputJsonVariableValueRequest == null && namedScenarioInputChatHistoryVariableValueRequest == null && namedScenarioInputAudioVariableValueRequest == null && namedScenarioInputVideoVariableValueRequest == null && namedScenarioInputImageVariableValueRequest == null && namedScenarioInputDocumentVariableValueRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputStringVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputStringVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputStringVariableValueRequest).Name}");
                    namedScenarioInputStringVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputJsonVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputJsonVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputJsonVariableValueRequest).Name}");
                    namedScenarioInputJsonVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest).Name}");
                    namedScenarioInputChatHistoryVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputAudioVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputAudioVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputAudioVariableValueRequest).Name}");
                    namedScenarioInputAudioVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputVideoVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputVideoVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputVideoVariableValueRequest).Name}");
                    namedScenarioInputVideoVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputImageVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputImageVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputImageVariableValueRequest).Name}");
                    namedScenarioInputImageVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputDocumentVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputDocumentVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputDocumentVariableValueRequest).Name}");
                    namedScenarioInputDocumentVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.NamedScenarioInputRequest(
                namedScenarioInputStringVariableValueRequest,

                namedScenarioInputJsonVariableValueRequest,

                namedScenarioInputChatHistoryVariableValueRequest,

                namedScenarioInputAudioVariableValueRequest,

                namedScenarioInputVideoVariableValueRequest,

                namedScenarioInputImageVariableValueRequest,

                namedScenarioInputDocumentVariableValueRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.NamedScenarioInputRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNamedScenarioInputStringVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputStringVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputStringVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputStringVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedScenarioInputStringVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedScenarioInputJsonVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputJsonVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputJsonVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputJsonVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedScenarioInputJsonVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedScenarioInputChatHistoryVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedScenarioInputChatHistoryVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedScenarioInputAudioVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputAudioVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputAudioVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputAudioVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedScenarioInputAudioVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedScenarioInputVideoVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputVideoVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputVideoVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputVideoVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedScenarioInputVideoVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedScenarioInputImageVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputImageVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputImageVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputImageVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedScenarioInputImageVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedScenarioInputDocumentVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedScenarioInputDocumentVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedScenarioInputDocumentVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedScenarioInputDocumentVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedScenarioInputDocumentVariableValueRequest!, typeInfo);
            }
        }
    }
}