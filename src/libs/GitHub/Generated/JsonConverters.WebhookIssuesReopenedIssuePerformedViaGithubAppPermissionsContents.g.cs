#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContentsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContents>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContents Read(
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
                        return global::GitHub.WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContentsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContents)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContents);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContents value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContentsExtensions.ToValueString(value));
        }
    }
}
