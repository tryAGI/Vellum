#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class MetadataFiltersRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.MetadataFiltersRequest>
    {
        /// <inheritdoc />
        public override global::Vellum.MetadataFiltersRequest Read(
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
            if (__jsonProps.Contains("combinator")) __score0++;
            if (__jsonProps.Contains("field")) __score0++;
            if (__jsonProps.Contains("negated")) __score0++;
            if (__jsonProps.Contains("operator")) __score0++;
            if (__jsonProps.Contains("rules")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vellum.MetadataFilterConfigRequest? metadataFilterConfigRequest = default;
            global::Vellum.VellumValueLogicalExpressionRequest? vellumValueLogicalExpressionRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.MetadataFilterConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.MetadataFilterConfigRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.MetadataFilterConfigRequest).Name}");
                        metadataFilterConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VellumValueLogicalExpressionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VellumValueLogicalExpressionRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VellumValueLogicalExpressionRequest).Name}");
                        vellumValueLogicalExpressionRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (metadataFilterConfigRequest == null && vellumValueLogicalExpressionRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.MetadataFilterConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.MetadataFilterConfigRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.MetadataFilterConfigRequest).Name}");
                    metadataFilterConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VellumValueLogicalExpressionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VellumValueLogicalExpressionRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VellumValueLogicalExpressionRequest).Name}");
                    vellumValueLogicalExpressionRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.MetadataFiltersRequest(
                metadataFilterConfigRequest,

                vellumValueLogicalExpressionRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.MetadataFiltersRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMetadataFilterConfigRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.MetadataFilterConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.MetadataFilterConfigRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.MetadataFilterConfigRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MetadataFilterConfigRequest!, typeInfo);
            }
            else if (value.IsVellumValueLogicalExpressionRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VellumValueLogicalExpressionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VellumValueLogicalExpressionRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VellumValueLogicalExpressionRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VellumValueLogicalExpressionRequest!.Value, typeInfo);
            }
        }
    }
}