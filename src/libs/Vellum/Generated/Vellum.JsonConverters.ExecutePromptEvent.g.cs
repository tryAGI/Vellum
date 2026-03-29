#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class ExecutePromptEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.ExecutePromptEvent>
    {
        /// <inheritdoc />
        public override global::Vellum.ExecutePromptEvent Read(
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
            if (__jsonProps.Contains("execution_id")) __score0++;
            if (__jsonProps.Contains("meta")) __score0++;
            if (__jsonProps.Contains("state")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("execution_id")) __score1++;
            if (__jsonProps.Contains("meta")) __score1++;
            if (__jsonProps.Contains("output")) __score1++;
            if (__jsonProps.Contains("output_index")) __score1++;
            if (__jsonProps.Contains("raw")) __score1++;
            if (__jsonProps.Contains("state")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("chat_message_metadata")) __score2++;
            if (__jsonProps.Contains("execution_id")) __score2++;
            if (__jsonProps.Contains("meta")) __score2++;
            if (__jsonProps.Contains("outputs")) __score2++;
            if (__jsonProps.Contains("state")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("error")) __score3++;
            if (__jsonProps.Contains("execution_id")) __score3++;
            if (__jsonProps.Contains("meta")) __score3++;
            if (__jsonProps.Contains("state")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Vellum.InitiatedExecutePromptEvent? initiatedExecutePromptEvent = default;
            global::Vellum.StreamingExecutePromptEvent? streamingExecutePromptEvent = default;
            global::Vellum.FulfilledExecutePromptEvent? fulfilledExecutePromptEvent = default;
            global::Vellum.RejectedExecutePromptEvent? rejectedExecutePromptEvent = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.InitiatedExecutePromptEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.InitiatedExecutePromptEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.InitiatedExecutePromptEvent).Name}");
                        initiatedExecutePromptEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StreamingExecutePromptEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StreamingExecutePromptEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StreamingExecutePromptEvent).Name}");
                        streamingExecutePromptEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FulfilledExecutePromptEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FulfilledExecutePromptEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FulfilledExecutePromptEvent).Name}");
                        fulfilledExecutePromptEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.RejectedExecutePromptEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.RejectedExecutePromptEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.RejectedExecutePromptEvent).Name}");
                        rejectedExecutePromptEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (initiatedExecutePromptEvent == null && streamingExecutePromptEvent == null && fulfilledExecutePromptEvent == null && rejectedExecutePromptEvent == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.InitiatedExecutePromptEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.InitiatedExecutePromptEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.InitiatedExecutePromptEvent).Name}");
                    initiatedExecutePromptEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StreamingExecutePromptEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StreamingExecutePromptEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StreamingExecutePromptEvent).Name}");
                    streamingExecutePromptEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FulfilledExecutePromptEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FulfilledExecutePromptEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FulfilledExecutePromptEvent).Name}");
                    fulfilledExecutePromptEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.RejectedExecutePromptEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.RejectedExecutePromptEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.RejectedExecutePromptEvent).Name}");
                    rejectedExecutePromptEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.ExecutePromptEvent(
                initiatedExecutePromptEvent,

                streamingExecutePromptEvent,

                fulfilledExecutePromptEvent,

                rejectedExecutePromptEvent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.ExecutePromptEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInitiatedExecutePromptEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.InitiatedExecutePromptEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.InitiatedExecutePromptEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.InitiatedExecutePromptEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InitiatedExecutePromptEvent, typeInfo);
            }
            else if (value.IsStreamingExecutePromptEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StreamingExecutePromptEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StreamingExecutePromptEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StreamingExecutePromptEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamingExecutePromptEvent, typeInfo);
            }
            else if (value.IsFulfilledExecutePromptEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FulfilledExecutePromptEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FulfilledExecutePromptEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FulfilledExecutePromptEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FulfilledExecutePromptEvent, typeInfo);
            }
            else if (value.IsRejectedExecutePromptEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.RejectedExecutePromptEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.RejectedExecutePromptEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.RejectedExecutePromptEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RejectedExecutePromptEvent, typeInfo);
            }
        }
    }
}