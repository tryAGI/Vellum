#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class VellumSpanJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.VellumSpan>
    {
        /// <inheritdoc />
        public override global::Vellum.VellumSpan Read(
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
            if (__jsonProps.Contains("attributes")) __score0++;
            if (__jsonProps.Contains("end_ts")) __score0++;
            if (__jsonProps.Contains("events")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("parent_span_id")) __score0++;
            if (__jsonProps.Contains("span_id")) __score0++;
            if (__jsonProps.Contains("start_ts")) __score0++;
            if (__jsonProps.Contains("usage_result")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("attributes")) __score1++;
            if (__jsonProps.Contains("end_ts")) __score1++;
            if (__jsonProps.Contains("events")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("parent_span_id")) __score1++;
            if (__jsonProps.Contains("span_id")) __score1++;
            if (__jsonProps.Contains("start_ts")) __score1++;
            if (__jsonProps.Contains("usage_result")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vellum.WorkflowExecutionSpan? workflowExecutionSpan = default;
            global::Vellum.NodeExecutionSpan? nodeExecutionSpan = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionSpan> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionSpan).Name}");
                        workflowExecutionSpan = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionSpan> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionSpan).Name}");
                        nodeExecutionSpan = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (workflowExecutionSpan == null && nodeExecutionSpan == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionSpan> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionSpan).Name}");
                    workflowExecutionSpan = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionSpan> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionSpan).Name}");
                    nodeExecutionSpan = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.VellumSpan(
                workflowExecutionSpan,

                nodeExecutionSpan
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.VellumSpan value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWorkflowExecutionSpan)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionSpan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionSpan, typeInfo);
            }
            else if (value.IsNodeExecutionSpan)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeExecutionSpan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeExecutionSpan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeExecutionSpan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeExecutionSpan, typeInfo);
            }
        }
    }
}