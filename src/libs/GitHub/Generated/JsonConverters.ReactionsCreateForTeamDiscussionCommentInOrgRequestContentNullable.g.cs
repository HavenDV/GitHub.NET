#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReactionsCreateForTeamDiscussionCommentInOrgRequestContentNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent?>
    {
        /// <inheritdoc />
        public override global::GitHub.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent? Read(
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
                        return global::GitHub.ReactionsCreateForTeamDiscussionCommentInOrgRequestContentExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.ReactionsCreateForTeamDiscussionCommentInOrgRequestContentExtensions.ToValueString(value.Value));
            }
        }
    }
}
