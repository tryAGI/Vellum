#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class WorkflowNodeResultDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.WorkflowNodeResultData>
    {
        /// <inheritdoc />
        public override global::Vellum.WorkflowNodeResultData Read(
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
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("data.array_output_id")) __score0++;
            if (__jsonProps.Contains("data.delta")) __score0++;
            if (__jsonProps.Contains("data.execution_id")) __score0++;
            if (__jsonProps.Contains("data.execution_meta")) __score0++;
            if (__jsonProps.Contains("data.output_id")) __score0++;
            if (__jsonProps.Contains("data.text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("data.results")) __score1++;
            if (__jsonProps.Contains("data.results_output_id")) __score1++;
            if (__jsonProps.Contains("data.text")) __score1++;
            if (__jsonProps.Contains("data.text_output_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("data")) __score2++;
            if (__jsonProps.Contains("data.output")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("data")) __score3++;
            if (__jsonProps.Contains("data.log_output_id")) __score3++;
            if (__jsonProps.Contains("data.output")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("data")) __score4++;
            if (__jsonProps.Contains("data.source_handle_id")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("data")) __score5++;
            if (__jsonProps.Contains("data.json")) __score5++;
            if (__jsonProps.Contains("data.json_output_id")) __score5++;
            if (__jsonProps.Contains("data.status_code")) __score5++;
            if (__jsonProps.Contains("data.status_code_output_id")) __score5++;
            if (__jsonProps.Contains("data.text")) __score5++;
            if (__jsonProps.Contains("data.text_output_id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("data")) __score6++;
            if (__jsonProps.Contains("data.output")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("data")) __score7++;
            if (__jsonProps.Contains("data.paused_node_data")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("data")) __score8++;
            if (__jsonProps.Contains("data.execution_id")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("data")) __score10++;
            if (__jsonProps.Contains("data.execution_ids")) __score10++;
            if (__jsonProps.Contains("data.iteration_state")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
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

            global::Vellum.PromptNodeResult? promptNodeResult = default;
            global::Vellum.SearchNodeResult? searchNodeResult = default;
            global::Vellum.TemplatingNodeResult? templatingNodeResult = default;
            global::Vellum.CodeExecutionNodeResult? codeExecutionNodeResult = default;
            global::Vellum.ConditionalNodeResult? conditionalNodeResult = default;
            global::Vellum.ApiNodeResult? apiNodeResult = default;
            global::Vellum.TerminalNodeResult? terminalNodeResult = default;
            global::Vellum.MergeNodeResult? mergeNodeResult = default;
            global::Vellum.SubworkflowNodeResult? subworkflowNodeResult = default;
            global::Vellum.MetricNodeResult? metricNodeResult = default;
            global::Vellum.MapNodeResult? mapNodeResult = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PromptNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PromptNodeResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PromptNodeResult).Name}");
                        promptNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SearchNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SearchNodeResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SearchNodeResult).Name}");
                        searchNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeResult).Name}");
                        templatingNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeResult).Name}");
                        codeExecutionNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ConditionalNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ConditionalNodeResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ConditionalNodeResult).Name}");
                        conditionalNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ApiNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ApiNodeResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ApiNodeResult).Name}");
                        apiNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeResult).Name}");
                        terminalNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.MergeNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.MergeNodeResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.MergeNodeResult).Name}");
                        mergeNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SubworkflowNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SubworkflowNodeResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SubworkflowNodeResult).Name}");
                        subworkflowNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.MetricNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.MetricNodeResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.MetricNodeResult).Name}");
                        metricNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.MapNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.MapNodeResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.MapNodeResult).Name}");
                        mapNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (promptNodeResult == null && searchNodeResult == null && templatingNodeResult == null && codeExecutionNodeResult == null && conditionalNodeResult == null && apiNodeResult == null && terminalNodeResult == null && mergeNodeResult == null && subworkflowNodeResult == null && metricNodeResult == null && mapNodeResult == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PromptNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PromptNodeResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PromptNodeResult).Name}");
                    promptNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SearchNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SearchNodeResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SearchNodeResult).Name}");
                    searchNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeResult).Name}");
                    templatingNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeResult).Name}");
                    codeExecutionNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ConditionalNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ConditionalNodeResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ConditionalNodeResult).Name}");
                    conditionalNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ApiNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ApiNodeResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ApiNodeResult).Name}");
                    apiNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeResult).Name}");
                    terminalNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.MergeNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.MergeNodeResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.MergeNodeResult).Name}");
                    mergeNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SubworkflowNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SubworkflowNodeResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SubworkflowNodeResult).Name}");
                    subworkflowNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.MetricNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.MetricNodeResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.MetricNodeResult).Name}");
                    metricNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.MapNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.MapNodeResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.MapNodeResult).Name}");
                    mapNodeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.WorkflowNodeResultData(
                promptNodeResult,

                searchNodeResult,

                templatingNodeResult,

                codeExecutionNodeResult,

                conditionalNodeResult,

                apiNodeResult,

                terminalNodeResult,

                mergeNodeResult,

                subworkflowNodeResult,

                metricNodeResult,

                mapNodeResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.WorkflowNodeResultData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPromptNodeResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PromptNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PromptNodeResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PromptNodeResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PromptNodeResult!, typeInfo);
            }
            else if (value.IsSearchNodeResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SearchNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SearchNodeResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SearchNodeResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchNodeResult!, typeInfo);
            }
            else if (value.IsTemplatingNodeResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TemplatingNodeResult!, typeInfo);
            }
            else if (value.IsCodeExecutionNodeResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionNodeResult!, typeInfo);
            }
            else if (value.IsConditionalNodeResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ConditionalNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ConditionalNodeResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ConditionalNodeResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConditionalNodeResult!, typeInfo);
            }
            else if (value.IsApiNodeResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ApiNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ApiNodeResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ApiNodeResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiNodeResult!, typeInfo);
            }
            else if (value.IsTerminalNodeResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TerminalNodeResult!, typeInfo);
            }
            else if (value.IsMergeNodeResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.MergeNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.MergeNodeResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.MergeNodeResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MergeNodeResult!, typeInfo);
            }
            else if (value.IsSubworkflowNodeResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SubworkflowNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SubworkflowNodeResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SubworkflowNodeResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubworkflowNodeResult!, typeInfo);
            }
            else if (value.IsMetricNodeResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.MetricNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.MetricNodeResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.MetricNodeResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MetricNodeResult!, typeInfo);
            }
            else if (value.IsMapNodeResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.MapNodeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.MapNodeResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.MapNodeResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MapNodeResult!, typeInfo);
            }
        }
    }
}