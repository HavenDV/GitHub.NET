#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChecksUpdateRequestOutputAnnotationAnnotationLevelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.ChecksUpdateRequestOutputAnnotationAnnotationLevel?>
    {
        /// <inheritdoc />
        public override global::GitHub.ChecksUpdateRequestOutputAnnotationAnnotationLevel? Read(
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
                        return global::GitHub.ChecksUpdateRequestOutputAnnotationAnnotationLevelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.ChecksUpdateRequestOutputAnnotationAnnotationLevel)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.ChecksUpdateRequestOutputAnnotationAnnotationLevel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.ChecksUpdateRequestOutputAnnotationAnnotationLevelExtensions.ToValueString(value.Value));
            }
        }
    }
}