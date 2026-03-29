#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class ExecutePromptResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.ExecutePromptResponse>
    {
        /// <inheritdoc />
        public override global::Vellum.ExecutePromptResponse Read(
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
            if (__jsonProps.Contains("chat_message_metadata")) __score0++;
            if (__jsonProps.Contains("execution_id")) __score0++;
            if (__jsonProps.Contains("meta")) __score0++;
            if (__jsonProps.Contains("outputs")) __score0++;
            if (__jsonProps.Contains("raw")) __score0++;
            if (__jsonProps.Contains("state")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("error")) __score1++;
            if (__jsonProps.Contains("execution_id")) __score1++;
            if (__jsonProps.Contains("meta")) __score1++;
            if (__jsonProps.Contains("raw")) __score1++;
            if (__jsonProps.Contains("state")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vellum.FulfilledExecutePromptResponse? fulfilledExecutePromptResponse = default;
            global::Vellum.RejectedExecutePromptResponse? rejectedExecutePromptResponse = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FulfilledExecutePromptResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FulfilledExecutePromptResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FulfilledExecutePromptResponse).Name}");
                        fulfilledExecutePromptResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.RejectedExecutePromptResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.RejectedExecutePromptResponse> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.RejectedExecutePromptResponse).Name}");
                        rejectedExecutePromptResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (fulfilledExecutePromptResponse == null && rejectedExecutePromptResponse == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FulfilledExecutePromptResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FulfilledExecutePromptResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FulfilledExecutePromptResponse).Name}");
                    fulfilledExecutePromptResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.RejectedExecutePromptResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.RejectedExecutePromptResponse> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.RejectedExecutePromptResponse).Name}");
                    rejectedExecutePromptResponse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.ExecutePromptResponse(
                fulfilledExecutePromptResponse,

                rejectedExecutePromptResponse
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.ExecutePromptResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFulfilledExecutePromptResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FulfilledExecutePromptResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FulfilledExecutePromptResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FulfilledExecutePromptResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FulfilledExecutePromptResponse, typeInfo);
            }
            else if (value.IsRejectedExecutePromptResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.RejectedExecutePromptResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.RejectedExecutePromptResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.RejectedExecutePromptResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RejectedExecutePromptResponse, typeInfo);
            }
        }
    }
}