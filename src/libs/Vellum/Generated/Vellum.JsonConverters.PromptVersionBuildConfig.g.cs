#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class PromptVersionBuildConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.PromptVersionBuildConfig>
    {
        /// <inheritdoc />
        public override global::Vellum.PromptVersionBuildConfig Read(
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
            if (__jsonProps.Contains("prompt_id")) __score0++;
            if (__jsonProps.Contains("sandbox_id")) __score0++;
            if (__jsonProps.Contains("sandbox_snapshot_id")) __score0++;
            if (__jsonProps.Contains("source")) __score0++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }

            global::Vellum.PromptVersionBuildConfigSandbox? promptVersionBuildConfigSandbox = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PromptVersionBuildConfigSandbox), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PromptVersionBuildConfigSandbox> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PromptVersionBuildConfigSandbox).Name}");
                        promptVersionBuildConfigSandbox = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (promptVersionBuildConfigSandbox == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PromptVersionBuildConfigSandbox), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PromptVersionBuildConfigSandbox> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PromptVersionBuildConfigSandbox).Name}");
                    promptVersionBuildConfigSandbox = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.PromptVersionBuildConfig(
                promptVersionBuildConfigSandbox
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.PromptVersionBuildConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPromptVersionBuildConfigSandbox)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PromptVersionBuildConfigSandbox), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PromptVersionBuildConfigSandbox?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PromptVersionBuildConfigSandbox).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PromptVersionBuildConfigSandbox!, typeInfo);
            }
        }
    }
}