#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookWorkflowJobCompletedWorkflowJobVariant1StatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookWorkflowJobCompletedWorkflowJobVariant1Status?>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookWorkflowJobCompletedWorkflowJobVariant1Status? Read(
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
                        return global::GitHub.WebhookWorkflowJobCompletedWorkflowJobVariant1StatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookWorkflowJobCompletedWorkflowJobVariant1Status)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhookWorkflowJobCompletedWorkflowJobVariant1Status?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookWorkflowJobCompletedWorkflowJobVariant1Status? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.WebhookWorkflowJobCompletedWorkflowJobVariant1StatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
