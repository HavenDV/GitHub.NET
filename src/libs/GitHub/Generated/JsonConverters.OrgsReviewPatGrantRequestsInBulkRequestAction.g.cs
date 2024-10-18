#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class OrgsReviewPatGrantRequestsInBulkRequestActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.OrgsReviewPatGrantRequestsInBulkRequestAction>
    {
        /// <inheritdoc />
        public override global::GitHub.OrgsReviewPatGrantRequestsInBulkRequestAction Read(
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
                        return global::GitHub.OrgsReviewPatGrantRequestsInBulkRequestActionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.OrgsReviewPatGrantRequestsInBulkRequestAction)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.OrgsReviewPatGrantRequestsInBulkRequestAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.OrgsReviewPatGrantRequestsInBulkRequestActionExtensions.ToValueString(value));
        }
    }
}
