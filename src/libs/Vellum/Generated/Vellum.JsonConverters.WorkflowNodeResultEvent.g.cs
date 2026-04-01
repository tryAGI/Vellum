#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class WorkflowNodeResultEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.WorkflowNodeResultEvent>
    {
        /// <inheritdoc />
        public override global::Vellum.WorkflowNodeResultEvent Read(
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
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("input_values")) __score0++;
            if (__jsonProps.Contains("node_id")) __score0++;
            if (__jsonProps.Contains("node_result_id")) __score0++;
            if (__jsonProps.Contains("source_execution_id")) __score0++;
            if (__jsonProps.Contains("state")) __score0++;
            if (__jsonProps.Contains("ts")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("node_id")) __score1++;
            if (__jsonProps.Contains("node_result_id")) __score1++;
            if (__jsonProps.Contains("output")) __score1++;
            if (__jsonProps.Contains("output_index")) __score1++;
            if (__jsonProps.Contains("source_execution_id")) __score1++;
            if (__jsonProps.Contains("state")) __score1++;
            if (__jsonProps.Contains("ts")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("data")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("mocked")) __score2++;
            if (__jsonProps.Contains("node_id")) __score2++;
            if (__jsonProps.Contains("node_result_id")) __score2++;
            if (__jsonProps.Contains("output_values")) __score2++;
            if (__jsonProps.Contains("source_execution_id")) __score2++;
            if (__jsonProps.Contains("state")) __score2++;
            if (__jsonProps.Contains("ts")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("data")) __score3++;
            if (__jsonProps.Contains("error")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("node_id")) __score3++;
            if (__jsonProps.Contains("node_result_id")) __score3++;
            if (__jsonProps.Contains("source_execution_id")) __score3++;
            if (__jsonProps.Contains("state")) __score3++;
            if (__jsonProps.Contains("ts")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Vellum.InitiatedWorkflowNodeResultEvent? initiatedWorkflowNodeResultEvent = default;
            global::Vellum.StreamingWorkflowNodeResultEvent? streamingWorkflowNodeResultEvent = default;
            global::Vellum.FulfilledWorkflowNodeResultEvent? fulfilledWorkflowNodeResultEvent = default;
            global::Vellum.RejectedWorkflowNodeResultEvent? rejectedWorkflowNodeResultEvent = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.InitiatedWorkflowNodeResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.InitiatedWorkflowNodeResultEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.InitiatedWorkflowNodeResultEvent).Name}");
                        initiatedWorkflowNodeResultEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StreamingWorkflowNodeResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StreamingWorkflowNodeResultEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StreamingWorkflowNodeResultEvent).Name}");
                        streamingWorkflowNodeResultEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FulfilledWorkflowNodeResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FulfilledWorkflowNodeResultEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FulfilledWorkflowNodeResultEvent).Name}");
                        fulfilledWorkflowNodeResultEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.RejectedWorkflowNodeResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.RejectedWorkflowNodeResultEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.RejectedWorkflowNodeResultEvent).Name}");
                        rejectedWorkflowNodeResultEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (initiatedWorkflowNodeResultEvent == null && streamingWorkflowNodeResultEvent == null && fulfilledWorkflowNodeResultEvent == null && rejectedWorkflowNodeResultEvent == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.InitiatedWorkflowNodeResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.InitiatedWorkflowNodeResultEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.InitiatedWorkflowNodeResultEvent).Name}");
                    initiatedWorkflowNodeResultEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StreamingWorkflowNodeResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StreamingWorkflowNodeResultEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StreamingWorkflowNodeResultEvent).Name}");
                    streamingWorkflowNodeResultEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FulfilledWorkflowNodeResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FulfilledWorkflowNodeResultEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FulfilledWorkflowNodeResultEvent).Name}");
                    fulfilledWorkflowNodeResultEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.RejectedWorkflowNodeResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.RejectedWorkflowNodeResultEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.RejectedWorkflowNodeResultEvent).Name}");
                    rejectedWorkflowNodeResultEvent = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.WorkflowNodeResultEvent(
                initiatedWorkflowNodeResultEvent,

                streamingWorkflowNodeResultEvent,

                fulfilledWorkflowNodeResultEvent,

                rejectedWorkflowNodeResultEvent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.WorkflowNodeResultEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInitiatedWorkflowNodeResultEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.InitiatedWorkflowNodeResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.InitiatedWorkflowNodeResultEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.InitiatedWorkflowNodeResultEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InitiatedWorkflowNodeResultEvent!, typeInfo);
            }
            else if (value.IsStreamingWorkflowNodeResultEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.StreamingWorkflowNodeResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.StreamingWorkflowNodeResultEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.StreamingWorkflowNodeResultEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamingWorkflowNodeResultEvent!, typeInfo);
            }
            else if (value.IsFulfilledWorkflowNodeResultEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FulfilledWorkflowNodeResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FulfilledWorkflowNodeResultEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FulfilledWorkflowNodeResultEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FulfilledWorkflowNodeResultEvent!, typeInfo);
            }
            else if (value.IsRejectedWorkflowNodeResultEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.RejectedWorkflowNodeResultEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.RejectedWorkflowNodeResultEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.RejectedWorkflowNodeResultEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RejectedWorkflowNodeResultEvent!, typeInfo);
            }
        }
    }
}