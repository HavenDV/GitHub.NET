#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReposCreateCommitStatusRequestStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.ReposCreateCommitStatusRequestState>
    {
        /// <inheritdoc />
        public override global::GitHub.ReposCreateCommitStatusRequestState Read(
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
                        return global::GitHub.ReposCreateCommitStatusRequestStateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.ReposCreateCommitStatusRequestState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.ReposCreateCommitStatusRequestState);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.ReposCreateCommitStatusRequestState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.ReposCreateCommitStatusRequestStateExtensions.ToValueString(value));
        }
    }
}
