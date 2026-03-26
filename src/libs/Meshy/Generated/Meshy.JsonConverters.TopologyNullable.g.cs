#nullable enable

namespace Meshy.JsonConverters
{
    /// <inheritdoc />
    public sealed class TopologyNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Meshy.Topology?>
    {
        /// <inheritdoc />
        public override global::Meshy.Topology? Read(
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
                        return global::Meshy.TopologyExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Meshy.Topology)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Meshy.Topology?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Meshy.Topology? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Meshy.TopologyExtensions.ToValueString(value.Value));
            }
        }
    }
}
