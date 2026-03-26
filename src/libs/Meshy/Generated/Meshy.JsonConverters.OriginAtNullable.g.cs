#nullable enable

namespace Meshy.JsonConverters
{
    /// <inheritdoc />
    public sealed class OriginAtNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Meshy.OriginAt?>
    {
        /// <inheritdoc />
        public override global::Meshy.OriginAt? Read(
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
                        return global::Meshy.OriginAtExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Meshy.OriginAt)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Meshy.OriginAt?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Meshy.OriginAt? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Meshy.OriginAtExtensions.ToValueString(value.Value));
            }
        }
    }
}
