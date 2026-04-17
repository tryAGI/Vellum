#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class WorkflowEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.WorkflowEvent>
    {
        /// <inheritdoc />
        public override global::Vellum.WorkflowEvent Read(
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
            if (__jsonProps.Contains("api_version")) __score0++;
            if (__jsonProps.Contains("body")) __score0++;
            if (__jsonProps.Contains("body.inputs")) __score0++;
            if (__jsonProps.Contains("body.node_definition")) __score0++;
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
            if (__jsonProps.Contains("body.node_definition")) __score1++;
            if (__jsonProps.Contains("body.output")) __score1++;
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
            if (__jsonProps.Contains("body.invoked_ports")) __score2++;
            if (__jsonProps.Contains("body.mocked")) __score2++;
            if (__jsonProps.Contains("body.node_definition")) __score2++;
            if (__jsonProps.Contains("body.outputs")) __score2++;
            if (__jsonProps.Contains("body.redacted")) __score2++;
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
            if (__jsonProps.Contains("body.error")) __score3++;
            if (__jsonProps.Contains("body.node_definition")) __score3++;
            if (__jsonProps.Contains("body.stacktrace")) __score3++;
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
            if (__jsonProps.Contains("body.node_definition")) __score4++;
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
            if (__jsonProps.Contains("body.node_definition")) __score5++;
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
            if (__jsonProps.Contains("body.attributes")) __score6++;
            if (__jsonProps.Contains("body.message")) __score6++;
            if (__jsonProps.Contains("body.node_definition")) __score6++;
            if (__jsonProps.Contains("body.severity")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("links")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("parent")) __score6++;
            if (__jsonProps.Contains("span_id")) __score6++;
            if (__jsonProps.Contains("timestamp")) __score6++;
            if (__jsonProps.Contains("trace_id")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("api_version")) __score7++;
            if (__jsonProps.Contains("body")) __score7++;
            if (__jsonProps.Contains("body.inputs")) __score7++;
            if (__jsonProps.Contains("body.trigger")) __score7++;
            if (__jsonProps.Contains("body.workflow_definition")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("links")) __score7++;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("parent")) __score7++;
            if (__jsonProps.Contains("span_id")) __score7++;
            if (__jsonProps.Contains("timestamp")) __score7++;
            if (__jsonProps.Contains("trace_id")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("api_version")) __score8++;
            if (__jsonProps.Contains("body")) __score8++;
            if (__jsonProps.Contains("body.output")) __score8++;
            if (__jsonProps.Contains("body.workflow_definition")) __score8++;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("links")) __score8++;
            if (__jsonProps.Contains("name")) __score8++;
            if (__jsonProps.Contains("parent")) __score8++;
            if (__jsonProps.Contains("span_id")) __score8++;
            if (__jsonProps.Contains("timestamp")) __score8++;
            if (__jsonProps.Contains("trace_id")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("api_version")) __score9++;
            if (__jsonProps.Contains("body")) __score9++;
            if (__jsonProps.Contains("body.error")) __score9++;
            if (__jsonProps.Contains("body.stacktrace")) __score9++;
            if (__jsonProps.Contains("body.workflow_definition")) __score9++;
            if (__jsonProps.Contains("id")) __score9++;
            if (__jsonProps.Contains("links")) __score9++;
            if (__jsonProps.Contains("name")) __score9++;
            if (__jsonProps.Contains("parent")) __score9++;
            if (__jsonProps.Contains("span_id")) __score9++;
            if (__jsonProps.Contains("timestamp")) __score9++;
            if (__jsonProps.Contains("trace_id")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("api_version")) __score10++;
            if (__jsonProps.Contains("body")) __score10++;
            if (__jsonProps.Contains("body.final_state")) __score10++;
            if (__jsonProps.Contains("body.outputs")) __score10++;
            if (__jsonProps.Contains("body.redacted")) __score10++;
            if (__jsonProps.Contains("body.server_metadata")) __score10++;
            if (__jsonProps.Contains("body.workflow_definition")) __score10++;
            if (__jsonProps.Contains("id")) __score10++;
            if (__jsonProps.Contains("links")) __score10++;
            if (__jsonProps.Contains("name")) __score10++;
            if (__jsonProps.Contains("parent")) __score10++;
            if (__jsonProps.Contains("span_id")) __score10++;
            if (__jsonProps.Contains("timestamp")) __score10++;
            if (__jsonProps.Contains("trace_id")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("api_version")) __score11++;
            if (__jsonProps.Contains("body")) __score11++;
            if (__jsonProps.Contains("body.external_inputs")) __score11++;
            if (__jsonProps.Contains("body.workflow_definition")) __score11++;
            if (__jsonProps.Contains("id")) __score11++;
            if (__jsonProps.Contains("links")) __score11++;
            if (__jsonProps.Contains("name")) __score11++;
            if (__jsonProps.Contains("parent")) __score11++;
            if (__jsonProps.Contains("span_id")) __score11++;
            if (__jsonProps.Contains("timestamp")) __score11++;
            if (__jsonProps.Contains("trace_id")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("api_version")) __score12++;
            if (__jsonProps.Contains("body")) __score12++;
            if (__jsonProps.Contains("body.workflow_definition")) __score12++;
            if (__jsonProps.Contains("id")) __score12++;
            if (__jsonProps.Contains("links")) __score12++;
            if (__jsonProps.Contains("name")) __score12++;
            if (__jsonProps.Contains("parent")) __score12++;
            if (__jsonProps.Contains("span_id")) __score12++;
            if (__jsonProps.Contains("timestamp")) __score12++;
            if (__jsonProps.Contains("trace_id")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("api_version")) __score13++;
            if (__jsonProps.Contains("body")) __score13++;
            if (__jsonProps.Contains("body.edited_by")) __score13++;
            if (__jsonProps.Contains("body.state")) __score13++;
            if (__jsonProps.Contains("body.workflow_definition")) __score13++;
            if (__jsonProps.Contains("id")) __score13++;
            if (__jsonProps.Contains("links")) __score13++;
            if (__jsonProps.Contains("name")) __score13++;
            if (__jsonProps.Contains("parent")) __score13++;
            if (__jsonProps.Contains("span_id")) __score13++;
            if (__jsonProps.Contains("timestamp")) __score13++;
            if (__jsonProps.Contains("trace_id")) __score13++;
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
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }

            global::Vellum.NodeExecutionInitiatedEvent? nodeExecutionInitiatedEvent = default;
            global::Vellum.NodeExecutionStreamingEvent? nodeExecutionStreamingEvent = default;
            global::Vellum.NodeExecutionFulfilledEvent? nodeExecutionFulfilledEvent = default;
            global::Vellum.NodeExecutionRejectedEvent? nodeExecutionRejectedEvent = default;
            global::Vellum.NodeExecutionPausedEvent? nodeExecutionPausedEvent = default;
            global::Vellum.NodeExecutionResumedEvent? nodeExecutionResumedEvent = default;
            global::Vellum.NodeExecutionLogEvent? nodeExecutionLogEvent = default;
            global::Vellum.WorkflowExecutionInitiatedEvent? workflowExecutionInitiatedEvent = default;
            global::Vellum.WorkflowExecutionStreamingEvent? workflowExecutionStreamingEvent = default;
            global::Vellum.WorkflowExecutionRejectedEvent? workflowExecutionRejectedEvent = default;
            global::Vellum.WorkflowExecutionFulfilledEvent? workflowExecutionFulfilledEvent = default;
            global::Vellum.WorkflowExecutionPausedEvent? workflowExecutionPausedEvent = default;
            global::Vellum.WorkflowExecutionResumedEvent? workflowExecutionResumedEvent = default;
            global::Vellum.WorkflowExecutionSnapshottedEvent? workflowExecutionSnapshottedEvent = default;
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
                else if (__bestIndex == 7)
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
                else if (__bestIndex == 8)
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
                else if (__bestIndex == 9)
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
                else if (__bestIndex == 10)
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
                else if (__bestIndex == 11)
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
                else if (__bestIndex == 12)
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
                else if (__bestIndex == 13)
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

            if (nodeExecutionInitiatedEvent == null && nodeExecutionStreamingEvent == null && nodeExecutionFulfilledEvent == null && nodeExecutionRejectedEvent == null && nodeExecutionPausedEvent == null && nodeExecutionResumedEvent == null && nodeExecutionLogEvent == null && workflowExecutionInitiatedEvent == null && workflowExecutionStreamingEvent == null && workflowExecutionRejectedEvent == null && workflowExecutionFulfilledEvent == null && workflowExecutionPausedEvent == null && workflowExecutionResumedEvent == null && workflowExecutionSnapshottedEvent == null)
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

            var __value = new global::Vellum.WorkflowEvent(
                nodeExecutionInitiatedEvent,

                nodeExecutionStreamingEvent,

                nodeExecutionFulfilledEvent,

                nodeExecutionRejectedEvent,

                nodeExecutionPausedEvent,

                nodeExecutionResumedEvent,

                nodeExecutionLogEvent,

                workflowExecutionInitiatedEvent,

                workflowExecutionStreamingEvent,

                workflowExecutionRejectedEvent,

                workflowExecutionFulfilledEvent,

                workflowExecutionPausedEvent,

                workflowExecutionResumedEvent,

                workflowExecutionSnapshottedEvent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.WorkflowEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNodeExecutionInitiatedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionInitiatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionInitiatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionInitiatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionInitiatedEvent!, typeInfo);
            }
            else if (value.IsNodeExecutionStreamingEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionStreamingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionStreamingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionStreamingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionStreamingEvent!, typeInfo);
            }
            else if (value.IsNodeExecutionFulfilledEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionFulfilledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionFulfilledEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionFulfilledEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionFulfilledEvent!, typeInfo);
            }
            else if (value.IsNodeExecutionRejectedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionRejectedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionRejectedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionRejectedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionRejectedEvent!, typeInfo);
            }
            else if (value.IsNodeExecutionPausedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionPausedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionPausedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionPausedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionPausedEvent!, typeInfo);
            }
            else if (value.IsNodeExecutionResumedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionResumedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionResumedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionResumedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionResumedEvent!, typeInfo);
            }
            else if (value.IsNodeExecutionLogEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionLogEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionLogEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionLogEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionLogEvent!, typeInfo);
            }
            else if (value.IsWorkflowExecutionInitiatedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionInitiatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionInitiatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionInitiatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionInitiatedEvent!, typeInfo);
            }
            else if (value.IsWorkflowExecutionStreamingEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionStreamingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionStreamingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionStreamingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionStreamingEvent!, typeInfo);
            }
            else if (value.IsWorkflowExecutionRejectedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionRejectedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionRejectedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionRejectedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionRejectedEvent!, typeInfo);
            }
            else if (value.IsWorkflowExecutionFulfilledEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionFulfilledEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionFulfilledEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionFulfilledEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionFulfilledEvent!, typeInfo);
            }
            else if (value.IsWorkflowExecutionPausedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionPausedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionPausedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionPausedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionPausedEvent!, typeInfo);
            }
            else if (value.IsWorkflowExecutionResumedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionResumedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionResumedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionResumedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionResumedEvent!, typeInfo);
            }
            else if (value.IsWorkflowExecutionSnapshottedEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionSnapshottedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionSnapshottedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionSnapshottedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionSnapshottedEvent!, typeInfo);
            }
        }
    }
}