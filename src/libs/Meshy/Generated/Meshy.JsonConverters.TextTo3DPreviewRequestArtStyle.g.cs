#nullable enable

namespace Meshy.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextTo3DPreviewRequestArtStyleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Meshy.TextTo3DPreviewRequestArtStyle>
    {
        /// <inheritdoc />
        public override global::Meshy.TextTo3DPreviewRequestArtStyle Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Meshy.TextTo3DPreviewRequestArtStyleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Meshy.TextTo3DPreviewRequestArtStyle)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Meshy.TextTo3DPreviewRequestArtStyle);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Meshy.TextTo3DPreviewRequestArtStyle value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Meshy.TextTo3DPreviewRequestArtStyleExtensions.ToValueString(value));
        }
    }
}
