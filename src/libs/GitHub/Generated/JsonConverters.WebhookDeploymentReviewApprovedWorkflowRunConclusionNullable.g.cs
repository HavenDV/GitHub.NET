#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookDeploymentReviewApprovedWorkflowRunConclusionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookDeploymentReviewApprovedWorkflowRunConclusion?>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookDeploymentReviewApprovedWorkflowRunConclusion? Read(
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
                        return global::GitHub.WebhookDeploymentReviewApprovedWorkflowRunConclusionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookDeploymentReviewApprovedWorkflowRunConclusion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhookDeploymentReviewApprovedWorkflowRunConclusion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookDeploymentReviewApprovedWorkflowRunConclusion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.WebhookDeploymentReviewApprovedWorkflowRunConclusionExtensions.ToValueString(value.Value));
            }
        }
    }
}
