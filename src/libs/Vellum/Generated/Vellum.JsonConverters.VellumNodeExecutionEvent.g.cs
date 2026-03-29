#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class VellumNodeExecutionEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.VellumNodeExecutionEvent>
    {
        /// <inheritdoc />
        public override global::Vellum.VellumNodeExecutionEvent Read(
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
            if (__jsonProps.Contains("api_version")) __score0++;
            if (__jsonProps.Contains("body")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("links")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("parent")) __score0++;
            if (__jsonProps.Contains("span_id")) __score0++;
            if (__jsonProps.Contains("timestamp")) __score0++;
            if (__jsonProps.Contains("trace_id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("api_version")) __score1++;
            if (__jsonProps.Contains("body")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("links")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("parent")) __score1++;
            if (__jsonProps.Contains("span_id")) __score1++;
            if (__jsonProps.Contains("timestamp")) __score1++;
            if (__jsonProps.Contains("trace_id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("api_version")) __score2++;
            if (__jsonProps.Contains("body")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("links")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("parent")) __score2++;
            if (__jsonProps.Contains("span_id")) __score2++;
            if (__jsonProps.Contains("timestamp")) __score2++;
            if (__jsonProps.Contains("trace_id")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("api_version")) __score3++;
            if (__jsonProps.Contains("body")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("links")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("parent")) __score3++;
            if (__jsonProps.Contains("span_id")) __score3++;
            if (__jsonProps.Contains("timestamp")) __score3++;
            if (__jsonProps.Contains("trace_id")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("api_version")) __score4++;
            if (__jsonProps.Contains("body")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("links")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("parent")) __score4++;
            if (__jsonProps.Contains("span_id")) __score4++;
            if (__jsonProps.Contains("timestamp")) __score4++;
            if (__jsonProps.Contains("trace_id")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("api_version")) __score5++;
            if (__jsonProps.Contains("body")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("links")) __score5++;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("parent")) __score5++;
            if (__jsonProps.Contains("span_id")) __score5++;
            if (__jsonProps.Contains("timestamp")) __score5++;
            if (__jsonProps.Contains("trace_id")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("api_version")) __score6++;
            if (__jsonProps.Contains("body")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("links")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("parent")) __score6++;
            if (__jsonProps.Contains("span_id")) __score6++;
            if (__jsonProps.Contains("timestamp")) __score6++;
            if (__jsonProps.Contains("trace_id")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::Vellum.NodeExecutionInitiatedEvent? nodeExecutionInitiatedEvent = default;
            global::Vellum.NodeExecutionStreamingEvent? nodeExecutionStreamingEvent = default;
            global::Vellum.NodeExecutionFulfilledEvent? nodeExecutionFulfilledEvent = default;
            global::Vellum.NodeExecutionRejectedEvent? nodeExecutionRejectedEvent = default;
            global::Vellum.NodeExecutionPausedEvent? nodeExecutionPausedEvent = default;
            global::Vellum.NodeExecutionResumedEvent? nodeExecutionResumedEvent = default;
            global::Vellum.NodeExecutionLogEvent? nodeExecutionLogEvent = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionInitiatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionInitiatedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionInitiatedEvent).Name}");
                        nodeExecutionInitiatedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionStreamingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionStreamingEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionStreamingEvent).Name}");
                        nodeExecutionStreamingEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionFulfilledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionFulfilledEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionFulfilledEvent).Name}");
                        nodeExecutionFulfilledEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionRejectedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionRejectedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionRejectedEvent).Name}");
                        nodeExecutionRejectedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionPausedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionPausedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionPausedEvent).Name}");
                        nodeExecutionPausedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionResumedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionResumedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionResumedEvent).Name}");
                        nodeExecutionResumedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionLogEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionLogEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionLogEvent).Name}");
                        nodeExecutionLogEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (nodeExecutionInitiatedEvent == null && nodeExecutionStreamingEvent == null && nodeExecutionFulfilledEvent == null && nodeExecutionRejectedEvent == null && nodeExecutionPausedEvent == null && nodeExecutionResumedEvent == null && nodeExecutionLogEvent == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionInitiatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionInitiatedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionInitiatedEvent).Name}");
                    nodeExecutionInitiatedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionStreamingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionStreamingEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionStreamingEvent).Name}");
                    nodeExecutionStreamingEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionFulfilledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionFulfilledEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionFulfilledEvent).Name}");
                    nodeExecutionFulfilledEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionRejectedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionRejectedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionRejectedEvent).Name}");
                    nodeExecutionRejectedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionPausedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionPausedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionPausedEvent).Name}");
                    nodeExecutionPausedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionResumedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionResumedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionResumedEvent).Name}");
                    nodeExecutionResumedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionLogEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionLogEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionLogEvent).Name}");
                    nodeExecutionLogEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.VellumNodeExecutionEvent(
                nodeExecutionInitiatedEvent,

                nodeExecutionStreamingEvent,

                nodeExecutionFulfilledEvent,

                nodeExecutionRejectedEvent,

                nodeExecutionPausedEvent,

                nodeExecutionResumedEvent,

                nodeExecutionLogEvent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.VellumNodeExecutionEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNodeExecutionInitiatedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionInitiatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionInitiatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionInitiatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionInitiatedEvent, typeInfo);
            }
            else if (value.IsNodeExecutionStreamingEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionStreamingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionStreamingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionStreamingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionStreamingEvent, typeInfo);
            }
            else if (value.IsNodeExecutionFulfilledEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionFulfilledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionFulfilledEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionFulfilledEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionFulfilledEvent, typeInfo);
            }
            else if (value.IsNodeExecutionRejectedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionRejectedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionRejectedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionRejectedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionRejectedEvent, typeInfo);
            }
            else if (value.IsNodeExecutionPausedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionPausedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionPausedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionPausedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionPausedEvent, typeInfo);
            }
            else if (value.IsNodeExecutionResumedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionResumedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionResumedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionResumedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionResumedEvent, typeInfo);
            }
            else if (value.IsNodeExecutionLogEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionLogEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionLogEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionLogEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionLogEvent, typeInfo);
            }
        }
    }
}