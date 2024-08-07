#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class DependencyGraphDiffRangeResponseChangeTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.DependencyGraphDiffRangeResponseChangeType?>
    {
        /// <inheritdoc />
        public override global::GitHub.DependencyGraphDiffRangeResponseChangeType? Read(
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
                        return global::GitHub.DependencyGraphDiffRangeResponseChangeTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.DependencyGraphDiffRangeResponseChangeType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.DependencyGraphDiffRangeResponseChangeType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.DependencyGraphDiffRangeResponseChangeTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
