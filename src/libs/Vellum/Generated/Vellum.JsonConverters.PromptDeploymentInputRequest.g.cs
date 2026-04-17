#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class PromptDeploymentInputRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.PromptDeploymentInputRequest>
    {
        /// <inheritdoc />
        public override global::Vellum.PromptDeploymentInputRequest Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

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
            if (__jsonProps.Contains("value.metadata")) __score3++;
            if (__jsonProps.Contains("value.src")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            if (__jsonProps.Contains("value.metadata")) __score4++;
            if (__jsonProps.Contains("value.src")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("value")) __score5++;
            if (__jsonProps.Contains("value.metadata")) __score5++;
            if (__jsonProps.Contains("value.src")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("value")) __score6++;
            if (__jsonProps.Contains("value.metadata")) __score6++;
            if (__jsonProps.Contains("value.src")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::Vellum.StringInputRequest? stringInputRequest = default;
            global::Vellum.JSONInputRequest? jSONInputRequest = default;
            global::Vellum.ChatHistoryInputRequest? chatHistoryInputRequest = default;
            global::Vellum.AudioInputRequest? audioInputRequest = default;
            global::Vellum.VideoInputRequest? videoInputRequest = default;
            global::Vellum.ImageInputRequest? imageInputRequest = default;
            global::Vellum.DocumentInputRequest? documentInputRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringInputRequest).Name}");
                        stringInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.JSONInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.JSONInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.JSONInputRequest).Name}");
                        jSONInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ChatHistoryInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ChatHistoryInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ChatHistoryInputRequest).Name}");
                        chatHistoryInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioInputRequest).Name}");
                        audioInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoInputRequest).Name}");
                        videoInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageInputRequest).Name}");
                        imageInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentInputRequest).Name}");
                        documentInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (stringInputRequest == null && jSONInputRequest == null && chatHistoryInputRequest == null && audioInputRequest == null && videoInputRequest == null && imageInputRequest == null && documentInputRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringInputRequest).Name}");
                    stringInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.JSONInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.JSONInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.JSONInputRequest).Name}");
                    jSONInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ChatHistoryInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ChatHistoryInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ChatHistoryInputRequest).Name}");
                    chatHistoryInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioInputRequest).Name}");
                    audioInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoInputRequest).Name}");
                    videoInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageInputRequest).Name}");
                    imageInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentInputRequest).Name}");
                    documentInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.PromptDeploymentInputRequest(
                stringInputRequest,

                jSONInputRequest,

                chatHistoryInputRequest,

                audioInputRequest,

                videoInputRequest,

                imageInputRequest,

                documentInputRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.PromptDeploymentInputRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStringInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringInputRequest!, typeInfo);
            }
            else if (value.IsJSONInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.JSONInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.JSONInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.JSONInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JSONInputRequest!, typeInfo);
            }
            else if (value.IsChatHistoryInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ChatHistoryInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ChatHistoryInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ChatHistoryInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatHistoryInputRequest!, typeInfo);
            }
            else if (value.IsAudioInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioInputRequest!, typeInfo);
            }
            else if (value.IsVideoInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoInputRequest!, typeInfo);
            }
            else if (value.IsImageInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageInputRequest!, typeInfo);
            }
            else if (value.IsDocumentInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentInputRequest!, typeInfo);
            }
        }
    }
}