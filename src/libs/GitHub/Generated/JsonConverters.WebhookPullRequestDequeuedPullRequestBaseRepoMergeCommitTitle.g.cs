#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestDequeuedPullRequestBaseRepoMergeCommitTitleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookPullRequestDequeuedPullRequestBaseRepoMergeCommitTitle>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookPullRequestDequeuedPullRequestBaseRepoMergeCommitTitle Read(
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
                        return global::GitHub.WebhookPullRequestDequeuedPullRequestBaseRepoMergeCommitTitleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookPullRequestDequeuedPullRequestBaseRepoMergeCommitTitle)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhookPullRequestDequeuedPullRequestBaseRepoMergeCommitTitle);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookPullRequestDequeuedPullRequestBaseRepoMergeCommitTitle value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.WebhookPullRequestDequeuedPullRequestBaseRepoMergeCommitTitleExtensions.ToValueString(value));
        }
    }
}
