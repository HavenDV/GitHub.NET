#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitle?>
    {
        /// <inheritdoc />
        public override global::GitHub.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitle? Read(
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
                        return global::GitHub.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitle)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitle?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitle? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.NullableRepositoryWebhooksTemplateRepositoryMergeCommitTitleExtensions.ToValueString(value.Value));
            }
        }
    }
}
