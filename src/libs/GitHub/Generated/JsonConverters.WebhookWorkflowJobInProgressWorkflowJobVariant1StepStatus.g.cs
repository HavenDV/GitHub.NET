#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus Read(
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
                        return global::GitHub.WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatusExtensions.ToValueString(value));
        }
    }
}
