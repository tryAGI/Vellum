#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class ChatMessageContentRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.ChatMessageContentRequest>
    {
        /// <inheritdoc />
        public override global::Vellum.ChatMessageContentRequest Read(
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
            var __score5 = 0;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("value")) __score5++;
            var __score6 = 0;
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

            global::Vellum.StringChatMessageContentRequest? stringChatMessageContentRequest = default;
            global::Vellum.FunctionCallChatMessageContentRequest? functionCallChatMessageContentRequest = default;
            global::Vellum.ArrayChatMessageContentRequest? arrayChatMessageContentRequest = default;
            global::Vellum.AudioChatMessageContentRequest? audioChatMessageContentRequest = default;
            global::Vellum.VideoChatMessageContentRequest? videoChatMessageContentRequest = default;
            global::Vellum.ImageChatMessageContentRequest? imageChatMessageContentRequest = default;
            global::Vellum.DocumentChatMessageContentRequest? documentChatMessageContentRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringChatMessageContentRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringChatMessageContentRequest).Name}");
                        stringChatMessageContentRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallChatMessageContentRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallChatMessageContentRequest).Name}");
                        functionCallChatMessageContentRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ArrayChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ArrayChatMessageContentRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ArrayChatMessageContentRequest).Name}");
                        arrayChatMessageContentRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioChatMessageContentRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioChatMessageContentRequest).Name}");
                        audioChatMessageContentRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoChatMessageContentRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoChatMessageContentRequest).Name}");
                        videoChatMessageContentRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageChatMessageContentRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageChatMessageContentRequest).Name}");
                        imageChatMessageContentRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentChatMessageContentRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentChatMessageContentRequest).Name}");
                        documentChatMessageContentRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (stringChatMessageContentRequest == null && functionCallChatMessageContentRequest == null && arrayChatMessageContentRequest == null && audioChatMessageContentRequest == null && videoChatMessageContentRequest == null && imageChatMessageContentRequest == null && documentChatMessageContentRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringChatMessageContentRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringChatMessageContentRequest).Name}");
                    stringChatMessageContentRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallChatMessageContentRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallChatMessageContentRequest).Name}");
                    functionCallChatMessageContentRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ArrayChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ArrayChatMessageContentRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ArrayChatMessageContentRequest).Name}");
                    arrayChatMessageContentRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioChatMessageContentRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioChatMessageContentRequest).Name}");
                    audioChatMessageContentRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoChatMessageContentRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoChatMessageContentRequest).Name}");
                    videoChatMessageContentRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageChatMessageContentRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageChatMessageContentRequest).Name}");
                    imageChatMessageContentRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentChatMessageContentRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentChatMessageContentRequest).Name}");
                    documentChatMessageContentRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.ChatMessageContentRequest(
                stringChatMessageContentRequest,

                functionCallChatMessageContentRequest,

                arrayChatMessageContentRequest,

                audioChatMessageContentRequest,

                videoChatMessageContentRequest,

                imageChatMessageContentRequest,

                documentChatMessageContentRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.ChatMessageContentRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStringChatMessageContentRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringChatMessageContentRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringChatMessageContentRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringChatMessageContentRequest!, typeInfo);
            }
            else if (value.IsFunctionCallChatMessageContentRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallChatMessageContentRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallChatMessageContentRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallChatMessageContentRequest!, typeInfo);
            }
            else if (value.IsArrayChatMessageContentRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ArrayChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ArrayChatMessageContentRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ArrayChatMessageContentRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArrayChatMessageContentRequest!, typeInfo);
            }
            else if (value.IsAudioChatMessageContentRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioChatMessageContentRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioChatMessageContentRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioChatMessageContentRequest!, typeInfo);
            }
            else if (value.IsVideoChatMessageContentRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoChatMessageContentRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoChatMessageContentRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoChatMessageContentRequest!, typeInfo);
            }
            else if (value.IsImageChatMessageContentRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageChatMessageContentRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageChatMessageContentRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageChatMessageContentRequest!, typeInfo);
            }
            else if (value.IsDocumentChatMessageContentRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentChatMessageContentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentChatMessageContentRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentChatMessageContentRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentChatMessageContentRequest!, typeInfo);
            }
        }
    }
}