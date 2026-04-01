#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class ChatMessageContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.ChatMessageContent>
    {
        /// <inheritdoc />
        public override global::Vellum.ChatMessageContent Read(
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

            global::Vellum.StringChatMessageContent? stringChatMessageContent = default;
            global::Vellum.FunctionCallChatMessageContent? functionCallChatMessageContent = default;
            global::Vellum.ArrayChatMessageContent? arrayChatMessageContent = default;
            global::Vellum.AudioChatMessageContent? audioChatMessageContent = default;
            global::Vellum.VideoChatMessageContent? videoChatMessageContent = default;
            global::Vellum.ImageChatMessageContent? imageChatMessageContent = default;
            global::Vellum.DocumentChatMessageContent? documentChatMessageContent = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringChatMessageContent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringChatMessageContent).Name}");
                        stringChatMessageContent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallChatMessageContent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallChatMessageContent).Name}");
                        functionCallChatMessageContent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ArrayChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ArrayChatMessageContent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ArrayChatMessageContent).Name}");
                        arrayChatMessageContent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioChatMessageContent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioChatMessageContent).Name}");
                        audioChatMessageContent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoChatMessageContent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoChatMessageContent).Name}");
                        videoChatMessageContent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageChatMessageContent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageChatMessageContent).Name}");
                        imageChatMessageContent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentChatMessageContent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentChatMessageContent).Name}");
                        documentChatMessageContent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (stringChatMessageContent == null && functionCallChatMessageContent == null && arrayChatMessageContent == null && audioChatMessageContent == null && videoChatMessageContent == null && imageChatMessageContent == null && documentChatMessageContent == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringChatMessageContent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringChatMessageContent).Name}");
                    stringChatMessageContent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallChatMessageContent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallChatMessageContent).Name}");
                    functionCallChatMessageContent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ArrayChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ArrayChatMessageContent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ArrayChatMessageContent).Name}");
                    arrayChatMessageContent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioChatMessageContent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioChatMessageContent).Name}");
                    audioChatMessageContent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoChatMessageContent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoChatMessageContent).Name}");
                    videoChatMessageContent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageChatMessageContent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageChatMessageContent).Name}");
                    imageChatMessageContent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentChatMessageContent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentChatMessageContent).Name}");
                    documentChatMessageContent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.ChatMessageContent(
                stringChatMessageContent,

                functionCallChatMessageContent,

                arrayChatMessageContent,

                audioChatMessageContent,

                videoChatMessageContent,

                imageChatMessageContent,

                documentChatMessageContent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.ChatMessageContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStringChatMessageContent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringChatMessageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringChatMessageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringChatMessageContent!, typeInfo);
            }
            else if (value.IsFunctionCallChatMessageContent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallChatMessageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallChatMessageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallChatMessageContent!, typeInfo);
            }
            else if (value.IsArrayChatMessageContent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ArrayChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ArrayChatMessageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ArrayChatMessageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArrayChatMessageContent!, typeInfo);
            }
            else if (value.IsAudioChatMessageContent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioChatMessageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioChatMessageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioChatMessageContent!, typeInfo);
            }
            else if (value.IsVideoChatMessageContent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoChatMessageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoChatMessageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoChatMessageContent!, typeInfo);
            }
            else if (value.IsImageChatMessageContent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageChatMessageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageChatMessageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageChatMessageContent!, typeInfo);
            }
            else if (value.IsDocumentChatMessageContent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentChatMessageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentChatMessageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentChatMessageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentChatMessageContent!, typeInfo);
            }
        }
    }
}