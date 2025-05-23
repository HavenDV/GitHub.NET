#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookForkForkeeVariant1OwnerTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookForkForkeeVariant1OwnerType>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookForkForkeeVariant1OwnerType Read(
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
                        return global::GitHub.WebhookForkForkeeVariant1OwnerTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookForkForkeeVariant1OwnerType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhookForkForkeeVariant1OwnerType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookForkForkeeVariant1OwnerType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.WebhookForkForkeeVariant1OwnerTypeExtensions.ToValueString(value));
        }
    }
}
