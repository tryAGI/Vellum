#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class VellumWorkflowExecutionEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.VellumWorkflowExecutionEvent>
    {
        /// <inheritdoc />
        public override global::Vellum.VellumWorkflowExecutionEvent Read(
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

            global::Vellum.WorkflowExecutionInitiatedEvent? workflowExecutionInitiatedEvent = default;
            global::Vellum.WorkflowExecutionStreamingEvent? workflowExecutionStreamingEvent = default;
            global::Vellum.WorkflowExecutionFulfilledEvent? workflowExecutionFulfilledEvent = default;
            global::Vellum.WorkflowExecutionRejectedEvent? workflowExecutionRejectedEvent = default;
            global::Vellum.WorkflowExecutionPausedEvent? workflowExecutionPausedEvent = default;
            global::Vellum.WorkflowExecutionResumedEvent? workflowExecutionResumedEvent = default;
            global::Vellum.WorkflowExecutionSnapshottedEvent? workflowExecutionSnapshottedEvent = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionInitiatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionInitiatedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionInitiatedEvent).Name}");
                        workflowExecutionInitiatedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionStreamingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionStreamingEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionStreamingEvent).Name}");
                        workflowExecutionStreamingEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionFulfilledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionFulfilledEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionFulfilledEvent).Name}");
                        workflowExecutionFulfilledEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionRejectedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionRejectedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionRejectedEvent).Name}");
                        workflowExecutionRejectedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionPausedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionPausedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionPausedEvent).Name}");
                        workflowExecutionPausedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionResumedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionResumedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionResumedEvent).Name}");
                        workflowExecutionResumedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionSnapshottedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionSnapshottedEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionSnapshottedEvent).Name}");
                        workflowExecutionSnapshottedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (workflowExecutionInitiatedEvent == null && workflowExecutionStreamingEvent == null && workflowExecutionFulfilledEvent == null && workflowExecutionRejectedEvent == null && workflowExecutionPausedEvent == null && workflowExecutionResumedEvent == null && workflowExecutionSnapshottedEvent == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionInitiatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionInitiatedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionInitiatedEvent).Name}");
                    workflowExecutionInitiatedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionStreamingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionStreamingEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionStreamingEvent).Name}");
                    workflowExecutionStreamingEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionFulfilledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionFulfilledEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionFulfilledEvent).Name}");
                    workflowExecutionFulfilledEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionRejectedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionRejectedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionRejectedEvent).Name}");
                    workflowExecutionRejectedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionPausedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionPausedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionPausedEvent).Name}");
                    workflowExecutionPausedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionResumedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionResumedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionResumedEvent).Name}");
                    workflowExecutionResumedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionSnapshottedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionSnapshottedEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionSnapshottedEvent).Name}");
                    workflowExecutionSnapshottedEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.VellumWorkflowExecutionEvent(
                workflowExecutionInitiatedEvent,

                workflowExecutionStreamingEvent,

                workflowExecutionFulfilledEvent,

                workflowExecutionRejectedEvent,

                workflowExecutionPausedEvent,

                workflowExecutionResumedEvent,

                workflowExecutionSnapshottedEvent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.VellumWorkflowExecutionEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWorkflowExecutionInitiatedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionInitiatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionInitiatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionInitiatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionInitiatedEvent, typeInfo);
            }
            else if (value.IsWorkflowExecutionStreamingEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionStreamingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionStreamingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionStreamingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionStreamingEvent, typeInfo);
            }
            else if (value.IsWorkflowExecutionFulfilledEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionFulfilledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionFulfilledEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionFulfilledEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionFulfilledEvent, typeInfo);
            }
            else if (value.IsWorkflowExecutionRejectedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionRejectedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionRejectedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionRejectedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionRejectedEvent, typeInfo);
            }
            else if (value.IsWorkflowExecutionPausedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionPausedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionPausedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionPausedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionPausedEvent, typeInfo);
            }
            else if (value.IsWorkflowExecutionResumedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionResumedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionResumedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionResumedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionResumedEvent, typeInfo);
            }
            else if (value.IsWorkflowExecutionSnapshottedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionSnapshottedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionSnapshottedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionSnapshottedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionSnapshottedEvent, typeInfo);
            }
        }
    }
}