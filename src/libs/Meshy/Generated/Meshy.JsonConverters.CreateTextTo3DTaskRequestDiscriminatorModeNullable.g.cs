#nullable enable

namespace Meshy.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextTo3DTaskRequestDiscriminatorModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Meshy.CreateTextTo3DTaskRequestDiscriminatorMode?>
    {
        /// <inheritdoc />
        public override global::Meshy.CreateTextTo3DTaskRequestDiscriminatorMode? Read(
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
                        return global::Meshy.CreateTextTo3DTaskRequestDiscriminatorModeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Meshy.CreateTextTo3DTaskRequestDiscriminatorMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Meshy.CreateTextTo3DTaskRequestDiscriminatorMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Meshy.CreateTextTo3DTaskRequestDiscriminatorMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Meshy.CreateTextTo3DTaskRequestDiscriminatorModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
