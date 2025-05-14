#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitMessageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitMessage?>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitMessage? Read(
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
                        return global::GitHub.WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitMessageExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitMessage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitMessage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitMessage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.WebhookPullRequestUnassignedPullRequestHeadRepoMergeCommitMessageExtensions.ToValueString(value.Value));
            }
        }
    }
}
