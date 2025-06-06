#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookProjectsV2StatusUpdateEditedChangesStatusFromJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesStatusFrom>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesStatusFrom Read(
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
                        return global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesStatusFromExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesStatusFrom)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesStatusFrom);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesStatusFrom value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.WebhookProjectsV2StatusUpdateEditedChangesStatusFromExtensions.ToValueString(value));
        }
    }
}
