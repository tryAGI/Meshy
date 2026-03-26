#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Meshy.JsonConverters
{
    /// <inheritdoc />
    public class CreateTextTo3DTaskRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Meshy.CreateTextTo3DTaskRequest>
    {
        /// <inheritdoc />
        public override global::Meshy.CreateTextTo3DTaskRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Meshy.CreateTextTo3DTaskRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Meshy.CreateTextTo3DTaskRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Meshy.CreateTextTo3DTaskRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Meshy.TextTo3DPreviewRequest? preview = default;
            if (discriminator?.Mode == global::Meshy.CreateTextTo3DTaskRequestDiscriminatorMode.Preview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Meshy.TextTo3DPreviewRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Meshy.TextTo3DPreviewRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Meshy.TextTo3DPreviewRequest)}");
                preview = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Meshy.TextTo3DRefineRequest? refine = default;
            if (discriminator?.Mode == global::Meshy.CreateTextTo3DTaskRequestDiscriminatorMode.Refine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Meshy.TextTo3DRefineRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Meshy.TextTo3DRefineRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Meshy.TextTo3DRefineRequest)}");
                refine = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Meshy.CreateTextTo3DTaskRequest(
                discriminator?.Mode,
                preview,

                refine
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Meshy.CreateTextTo3DTaskRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPreview)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Meshy.TextTo3DPreviewRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Meshy.TextTo3DPreviewRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Meshy.TextTo3DPreviewRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Preview, typeInfo);
            }
            else if (value.IsRefine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Meshy.TextTo3DRefineRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Meshy.TextTo3DRefineRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Meshy.TextTo3DRefineRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Refine, typeInfo);
            }
        }
    }
}