#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType?>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType? Read(
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
                        return global::GitHub.WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneCreatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
