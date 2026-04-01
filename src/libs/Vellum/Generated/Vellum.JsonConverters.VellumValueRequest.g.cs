#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class VellumValueRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.VellumValueRequest>
    {
        /// <inheritdoc />
        public override global::Vellum.VellumValueRequest Read(
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
            var __score7 = 0;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("value")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("type")) __score8++;
            if (__jsonProps.Contains("value")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("type")) __score9++;
            if (__jsonProps.Contains("value")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("type")) __score10++;
            if (__jsonProps.Contains("value")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("type")) __score11++;
            if (__jsonProps.Contains("value")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("type")) __score12++;
            if (__jsonProps.Contains("value")) __score12++;
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
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }

            global::Vellum.StringVellumValueRequest? stringVellumValueRequest = default;
            global::Vellum.NumberVellumValueRequest? numberVellumValueRequest = default;
            global::Vellum.JsonVellumValueRequest? jsonVellumValueRequest = default;
            global::Vellum.AudioVellumValueRequest? audioVellumValueRequest = default;
            global::Vellum.VideoVellumValueRequest? videoVellumValueRequest = default;
            global::Vellum.ImageVellumValueRequest? imageVellumValueRequest = default;
            global::Vellum.DocumentVellumValueRequest? documentVellumValueRequest = default;
            global::Vellum.FunctionCallVellumValueRequest? functionCallVellumValueRequest = default;
            global::Vellum.ErrorVellumValueRequest? errorVellumValueRequest = default;
            global::Vellum.ArrayVellumValueRequest? arrayVellumValueRequest = default;
            global::Vellum.ChatHistoryVellumValueRequest? chatHistoryVellumValueRequest = default;
            global::Vellum.SearchResultsVellumValueRequest? searchResultsVellumValueRequest = default;
            global::Vellum.ThinkingVellumValueRequest? thinkingVellumValueRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringVellumValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringVellumValueRequest).Name}");
                        stringVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NumberVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NumberVellumValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NumberVellumValueRequest).Name}");
                        numberVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.JsonVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.JsonVellumValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.JsonVellumValueRequest).Name}");
                        jsonVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioVellumValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioVellumValueRequest).Name}");
                        audioVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoVellumValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoVellumValueRequest).Name}");
                        videoVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageVellumValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageVellumValueRequest).Name}");
                        imageVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentVellumValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentVellumValueRequest).Name}");
                        documentVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallVellumValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallVellumValueRequest).Name}");
                        functionCallVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ErrorVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ErrorVellumValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ErrorVellumValueRequest).Name}");
                        errorVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ArrayVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ArrayVellumValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ArrayVellumValueRequest).Name}");
                        arrayVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ChatHistoryVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ChatHistoryVellumValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ChatHistoryVellumValueRequest).Name}");
                        chatHistoryVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SearchResultsVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SearchResultsVellumValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SearchResultsVellumValueRequest).Name}");
                        searchResultsVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ThinkingVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ThinkingVellumValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ThinkingVellumValueRequest).Name}");
                        thinkingVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (stringVellumValueRequest == null && numberVellumValueRequest == null && jsonVellumValueRequest == null && audioVellumValueRequest == null && videoVellumValueRequest == null && imageVellumValueRequest == null && documentVellumValueRequest == null && functionCallVellumValueRequest == null && errorVellumValueRequest == null && arrayVellumValueRequest == null && chatHistoryVellumValueRequest == null && searchResultsVellumValueRequest == null && thinkingVellumValueRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringVellumValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringVellumValueRequest).Name}");
                    stringVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NumberVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NumberVellumValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NumberVellumValueRequest).Name}");
                    numberVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.JsonVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.JsonVellumValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.JsonVellumValueRequest).Name}");
                    jsonVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioVellumValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioVellumValueRequest).Name}");
                    audioVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoVellumValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoVellumValueRequest).Name}");
                    videoVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageVellumValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageVellumValueRequest).Name}");
                    imageVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentVellumValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentVellumValueRequest).Name}");
                    documentVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallVellumValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallVellumValueRequest).Name}");
                    functionCallVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ErrorVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ErrorVellumValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ErrorVellumValueRequest).Name}");
                    errorVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ArrayVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ArrayVellumValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ArrayVellumValueRequest).Name}");
                    arrayVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ChatHistoryVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ChatHistoryVellumValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ChatHistoryVellumValueRequest).Name}");
                    chatHistoryVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SearchResultsVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SearchResultsVellumValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SearchResultsVellumValueRequest).Name}");
                    searchResultsVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ThinkingVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ThinkingVellumValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ThinkingVellumValueRequest).Name}");
                    thinkingVellumValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.VellumValueRequest(
                stringVellumValueRequest,

                numberVellumValueRequest,

                jsonVellumValueRequest,

                audioVellumValueRequest,

                videoVellumValueRequest,

                imageVellumValueRequest,

                documentVellumValueRequest,

                functionCallVellumValueRequest,

                errorVellumValueRequest,

                arrayVellumValueRequest,

                chatHistoryVellumValueRequest,

                searchResultsVellumValueRequest,

                thinkingVellumValueRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.VellumValueRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStringVellumValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringVellumValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringVellumValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringVellumValueRequest!, typeInfo);
            }
            else if (value.IsNumberVellumValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NumberVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NumberVellumValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NumberVellumValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NumberVellumValueRequest!, typeInfo);
            }
            else if (value.IsJsonVellumValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.JsonVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.JsonVellumValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.JsonVellumValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonVellumValueRequest!, typeInfo);
            }
            else if (value.IsAudioVellumValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioVellumValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioVellumValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioVellumValueRequest!, typeInfo);
            }
            else if (value.IsVideoVellumValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoVellumValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoVellumValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoVellumValueRequest!, typeInfo);
            }
            else if (value.IsImageVellumValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageVellumValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageVellumValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageVellumValueRequest!, typeInfo);
            }
            else if (value.IsDocumentVellumValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentVellumValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentVellumValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentVellumValueRequest!, typeInfo);
            }
            else if (value.IsFunctionCallVellumValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallVellumValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallVellumValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallVellumValueRequest!, typeInfo);
            }
            else if (value.IsErrorVellumValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ErrorVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ErrorVellumValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ErrorVellumValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ErrorVellumValueRequest!, typeInfo);
            }
            else if (value.IsArrayVellumValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ArrayVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ArrayVellumValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ArrayVellumValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArrayVellumValueRequest!, typeInfo);
            }
            else if (value.IsChatHistoryVellumValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ChatHistoryVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ChatHistoryVellumValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ChatHistoryVellumValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatHistoryVellumValueRequest!, typeInfo);
            }
            else if (value.IsSearchResultsVellumValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SearchResultsVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SearchResultsVellumValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SearchResultsVellumValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResultsVellumValueRequest!, typeInfo);
            }
            else if (value.IsThinkingVellumValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ThinkingVellumValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ThinkingVellumValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ThinkingVellumValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingVellumValueRequest!, typeInfo);
            }
        }
    }
}