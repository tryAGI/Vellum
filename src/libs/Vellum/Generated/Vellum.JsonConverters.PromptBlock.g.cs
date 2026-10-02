#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class PromptBlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.PromptBlock>
    {
        /// <inheritdoc />
        public override global::Vellum.PromptBlock Read(
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
            if (__jsonProps.Contains("block_type")) __score0++;
            if (__jsonProps.Contains("cache_config")) __score0++;
            if (__jsonProps.Contains("state")) __score0++;
            if (__jsonProps.Contains("template")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("block_type")) __score1++;
            if (__jsonProps.Contains("blocks")) __score1++;
            if (__jsonProps.Contains("cache_config")) __score1++;
            if (__jsonProps.Contains("chat_message_unterminated")) __score1++;
            if (__jsonProps.Contains("chat_role")) __score1++;
            if (__jsonProps.Contains("chat_source")) __score1++;
            if (__jsonProps.Contains("state")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("block_type")) __score2++;
            if (__jsonProps.Contains("cache_config")) __score2++;
            if (__jsonProps.Contains("input_variable")) __score2++;
            if (__jsonProps.Contains("state")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("block_type")) __score3++;
            if (__jsonProps.Contains("blocks")) __score3++;
            if (__jsonProps.Contains("cache_config")) __score3++;
            if (__jsonProps.Contains("state")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("arguments")) __score4++;
            if (__jsonProps.Contains("block_type")) __score4++;
            if (__jsonProps.Contains("cache_config")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("state")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("block_type")) __score5++;
            if (__jsonProps.Contains("cache_config")) __score5++;
            if (__jsonProps.Contains("metadata")) __score5++;
            if (__jsonProps.Contains("src")) __score5++;
            if (__jsonProps.Contains("state")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("block_type")) __score6++;
            if (__jsonProps.Contains("cache_config")) __score6++;
            if (__jsonProps.Contains("metadata")) __score6++;
            if (__jsonProps.Contains("src")) __score6++;
            if (__jsonProps.Contains("state")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("block_type")) __score7++;
            if (__jsonProps.Contains("cache_config")) __score7++;
            if (__jsonProps.Contains("metadata")) __score7++;
            if (__jsonProps.Contains("src")) __score7++;
            if (__jsonProps.Contains("state")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("block_type")) __score8++;
            if (__jsonProps.Contains("cache_config")) __score8++;
            if (__jsonProps.Contains("metadata")) __score8++;
            if (__jsonProps.Contains("src")) __score8++;
            if (__jsonProps.Contains("state")) __score8++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }

            global::Vellum.JinjaPromptBlock? jinjaPromptBlock = default;
            global::Vellum.ChatMessagePromptBlock? chatMessagePromptBlock = default;
            global::Vellum.VariablePromptBlock? variablePromptBlock = default;
            global::Vellum.RichTextPromptBlock? richTextPromptBlock = default;
            global::Vellum.FunctionCallPromptBlock? functionCallPromptBlock = default;
            global::Vellum.AudioPromptBlock? audioPromptBlock = default;
            global::Vellum.VideoPromptBlock? videoPromptBlock = default;
            global::Vellum.ImagePromptBlock? imagePromptBlock = default;
            global::Vellum.DocumentPromptBlock? documentPromptBlock = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.JinjaPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.JinjaPromptBlock> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.JinjaPromptBlock).Name}");
                        jinjaPromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ChatMessagePromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ChatMessagePromptBlock> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ChatMessagePromptBlock).Name}");
                        chatMessagePromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VariablePromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VariablePromptBlock> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VariablePromptBlock).Name}");
                        variablePromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.RichTextPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.RichTextPromptBlock> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.RichTextPromptBlock).Name}");
                        richTextPromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallPromptBlock> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallPromptBlock).Name}");
                        functionCallPromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioPromptBlock> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioPromptBlock).Name}");
                        audioPromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoPromptBlock> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoPromptBlock).Name}");
                        videoPromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImagePromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImagePromptBlock> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImagePromptBlock).Name}");
                        imagePromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentPromptBlock> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentPromptBlock).Name}");
                        documentPromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (jinjaPromptBlock == null && chatMessagePromptBlock == null && variablePromptBlock == null && richTextPromptBlock == null && functionCallPromptBlock == null && audioPromptBlock == null && videoPromptBlock == null && imagePromptBlock == null && documentPromptBlock == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.JinjaPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.JinjaPromptBlock> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.JinjaPromptBlock).Name}");
                    jinjaPromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (jinjaPromptBlock == null && chatMessagePromptBlock == null && variablePromptBlock == null && richTextPromptBlock == null && functionCallPromptBlock == null && audioPromptBlock == null && videoPromptBlock == null && imagePromptBlock == null && documentPromptBlock == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ChatMessagePromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ChatMessagePromptBlock> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ChatMessagePromptBlock).Name}");
                    chatMessagePromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (jinjaPromptBlock == null && chatMessagePromptBlock == null && variablePromptBlock == null && richTextPromptBlock == null && functionCallPromptBlock == null && audioPromptBlock == null && videoPromptBlock == null && imagePromptBlock == null && documentPromptBlock == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VariablePromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VariablePromptBlock> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VariablePromptBlock).Name}");
                    variablePromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (jinjaPromptBlock == null && chatMessagePromptBlock == null && variablePromptBlock == null && richTextPromptBlock == null && functionCallPromptBlock == null && audioPromptBlock == null && videoPromptBlock == null && imagePromptBlock == null && documentPromptBlock == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.RichTextPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.RichTextPromptBlock> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.RichTextPromptBlock).Name}");
                    richTextPromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (jinjaPromptBlock == null && chatMessagePromptBlock == null && variablePromptBlock == null && richTextPromptBlock == null && functionCallPromptBlock == null && audioPromptBlock == null && videoPromptBlock == null && imagePromptBlock == null && documentPromptBlock == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallPromptBlock> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallPromptBlock).Name}");
                    functionCallPromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (jinjaPromptBlock == null && chatMessagePromptBlock == null && variablePromptBlock == null && richTextPromptBlock == null && functionCallPromptBlock == null && audioPromptBlock == null && videoPromptBlock == null && imagePromptBlock == null && documentPromptBlock == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioPromptBlock> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioPromptBlock).Name}");
                    audioPromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (jinjaPromptBlock == null && chatMessagePromptBlock == null && variablePromptBlock == null && richTextPromptBlock == null && functionCallPromptBlock == null && audioPromptBlock == null && videoPromptBlock == null && imagePromptBlock == null && documentPromptBlock == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoPromptBlock> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoPromptBlock).Name}");
                    videoPromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (jinjaPromptBlock == null && chatMessagePromptBlock == null && variablePromptBlock == null && richTextPromptBlock == null && functionCallPromptBlock == null && audioPromptBlock == null && videoPromptBlock == null && imagePromptBlock == null && documentPromptBlock == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImagePromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImagePromptBlock> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImagePromptBlock).Name}");
                    imagePromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (jinjaPromptBlock == null && chatMessagePromptBlock == null && variablePromptBlock == null && richTextPromptBlock == null && functionCallPromptBlock == null && audioPromptBlock == null && videoPromptBlock == null && imagePromptBlock == null && documentPromptBlock == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentPromptBlock> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentPromptBlock).Name}");
                    documentPromptBlock = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.PromptBlock(
                jinjaPromptBlock,

                chatMessagePromptBlock,

                variablePromptBlock,

                richTextPromptBlock,

                functionCallPromptBlock,

                audioPromptBlock,

                videoPromptBlock,

                imagePromptBlock,

                documentPromptBlock
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.PromptBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsJinjaPromptBlock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.JinjaPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.JinjaPromptBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.JinjaPromptBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickJinjaPromptBlock(), typeInfo);
            }
            else if (value.IsChatMessagePromptBlock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ChatMessagePromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ChatMessagePromptBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ChatMessagePromptBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickChatMessagePromptBlock(), typeInfo);
            }
            else if (value.IsVariablePromptBlock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VariablePromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VariablePromptBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VariablePromptBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickVariablePromptBlock(), typeInfo);
            }
            else if (value.IsRichTextPromptBlock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.RichTextPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.RichTextPromptBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.RichTextPromptBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRichTextPromptBlock(), typeInfo);
            }
            else if (value.IsFunctionCallPromptBlock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallPromptBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallPromptBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFunctionCallPromptBlock(), typeInfo);
            }
            else if (value.IsAudioPromptBlock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioPromptBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioPromptBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAudioPromptBlock(), typeInfo);
            }
            else if (value.IsVideoPromptBlock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoPromptBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoPromptBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickVideoPromptBlock(), typeInfo);
            }
            else if (value.IsImagePromptBlock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImagePromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImagePromptBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImagePromptBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImagePromptBlock(), typeInfo);
            }
            else if (value.IsDocumentPromptBlock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentPromptBlock), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentPromptBlock?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentPromptBlock).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDocumentPromptBlock(), typeInfo);
            }
        }
    }
}