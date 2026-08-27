#nullable enable

namespace Meshy.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListRetextureTasksSortByNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Meshy.ListRetextureTasksSortBy?>
    {
        /// <inheritdoc />
        public override global::Meshy.ListRetextureTasksSortBy? Read(
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
                        return global::Meshy.ListRetextureTasksSortByExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Meshy.ListRetextureTasksSortBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Meshy.ListRetextureTasksSortBy?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Meshy.ListRetextureTasksSortBy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Meshy.ListRetextureTasksSortByExtensions.ToValueString(value.Value));
            }
        }
    }
}
