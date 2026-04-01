#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class VellumValueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.VellumValue>
    {
        /// <inheritdoc />
        public override global::Vellum.VellumValue Read(
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

            global::Vellum.StringVellumValue? stringVellumValue = default;
            global::Vellum.NumberVellumValue? numberVellumValue = default;
            global::Vellum.JsonVellumValue? jsonVellumValue = default;
            global::Vellum.AudioVellumValue? audioVellumValue = default;
            global::Vellum.VideoVellumValue? videoVellumValue = default;
            global::Vellum.ImageVellumValue? imageVellumValue = default;
            global::Vellum.DocumentVellumValue? documentVellumValue = default;
            global::Vellum.FunctionCallVellumValue? functionCallVellumValue = default;
            global::Vellum.ErrorVellumValue? errorVellumValue = default;
            global::Vellum.ArrayVellumValue? arrayVellumValue = default;
            global::Vellum.ChatHistoryVellumValue? chatHistoryVellumValue = default;
            global::Vellum.SearchResultsVellumValue? searchResultsVellumValue = default;
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NumberVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NumberVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NumberVellumValue).Name}");
                        numberVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioVellumValue).Name}");
                        audioVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoVellumValue).Name}");
                        videoVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageVellumValue).Name}");
                        imageVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentVellumValue).Name}");
                        documentVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                else if (__bestIndex == 8)
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
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ArrayVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ArrayVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ArrayVellumValue).Name}");
                        arrayVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ChatHistoryVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ChatHistoryVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ChatHistoryVellumValue).Name}");
                        chatHistoryVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SearchResultsVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SearchResultsVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SearchResultsVellumValue).Name}");
                        searchResultsVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            if (stringVellumValue == null && numberVellumValue == null && jsonVellumValue == null && audioVellumValue == null && videoVellumValue == null && imageVellumValue == null && documentVellumValue == null && functionCallVellumValue == null && errorVellumValue == null && arrayVellumValue == null && chatHistoryVellumValue == null && searchResultsVellumValue == null && thinkingVellumValue == null)
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NumberVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NumberVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NumberVellumValue).Name}");
                    numberVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioVellumValue).Name}");
                    audioVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoVellumValue).Name}");
                    videoVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageVellumValue).Name}");
                    imageVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentVellumValue).Name}");
                    documentVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ArrayVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ArrayVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ArrayVellumValue).Name}");
                    arrayVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ChatHistoryVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ChatHistoryVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ChatHistoryVellumValue).Name}");
                    chatHistoryVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SearchResultsVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SearchResultsVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SearchResultsVellumValue).Name}");
                    searchResultsVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

            var __value = new global::Vellum.VellumValue(
                stringVellumValue,

                numberVellumValue,

                jsonVellumValue,

                audioVellumValue,

                videoVellumValue,

                imageVellumValue,

                documentVellumValue,

                functionCallVellumValue,

                errorVellumValue,

                arrayVellumValue,

                chatHistoryVellumValue,

                searchResultsVellumValue,

                thinkingVellumValue
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.VellumValue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStringVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StringVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StringVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StringVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringVellumValue!, typeInfo);
            }
            else if (value.IsNumberVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NumberVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NumberVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NumberVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NumberVellumValue!, typeInfo);
            }
            else if (value.IsJsonVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.JsonVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.JsonVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.JsonVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonVellumValue!, typeInfo);
            }
            else if (value.IsAudioVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.AudioVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.AudioVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.AudioVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioVellumValue!, typeInfo);
            }
            else if (value.IsVideoVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VideoVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VideoVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VideoVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoVellumValue!, typeInfo);
            }
            else if (value.IsImageVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ImageVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ImageVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ImageVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageVellumValue!, typeInfo);
            }
            else if (value.IsDocumentVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DocumentVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DocumentVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DocumentVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DocumentVellumValue!, typeInfo);
            }
            else if (value.IsFunctionCallVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FunctionCallVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FunctionCallVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FunctionCallVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallVellumValue!, typeInfo);
            }
            else if (value.IsErrorVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ErrorVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ErrorVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ErrorVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ErrorVellumValue!, typeInfo);
            }
            else if (value.IsArrayVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ArrayVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ArrayVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ArrayVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArrayVellumValue!, typeInfo);
            }
            else if (value.IsChatHistoryVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ChatHistoryVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ChatHistoryVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ChatHistoryVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatHistoryVellumValue!, typeInfo);
            }
            else if (value.IsSearchResultsVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SearchResultsVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SearchResultsVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SearchResultsVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResultsVellumValue!, typeInfo);
            }
            else if (value.IsThinkingVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ThinkingVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ThinkingVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ThinkingVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThinkingVellumValue!, typeInfo);
            }
        }
    }
}