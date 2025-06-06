#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class PullsListReviewCommentsForRepoDirectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.PullsListReviewCommentsForRepoDirection>
    {
        /// <inheritdoc />
        public override global::GitHub.PullsListReviewCommentsForRepoDirection Read(
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
                        return global::GitHub.PullsListReviewCommentsForRepoDirectionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.PullsListReviewCommentsForRepoDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.PullsListReviewCommentsForRepoDirection);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.PullsListReviewCommentsForRepoDirection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.PullsListReviewCommentsForRepoDirectionExtensions.ToValueString(value));
        }
    }
}
