#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReviewCommentStartSideNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.ReviewCommentStartSide?>
    {
        /// <inheritdoc />
        public override global::GitHub.ReviewCommentStartSide? Read(
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
                        return global::GitHub.ReviewCommentStartSideExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.ReviewCommentStartSide)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.ReviewCommentStartSide?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.ReviewCommentStartSide? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.ReviewCommentStartSideExtensions.ToValueString(value.Value));
            }
        }
    }
}
