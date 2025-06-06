#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProjectsListCardsArchivedStateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.ProjectsListCardsArchivedState?>
    {
        /// <inheritdoc />
        public override global::GitHub.ProjectsListCardsArchivedState? Read(
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
                        return global::GitHub.ProjectsListCardsArchivedStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.ProjectsListCardsArchivedState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.ProjectsListCardsArchivedState?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.ProjectsListCardsArchivedState? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.ProjectsListCardsArchivedStateExtensions.ToValueString(value.Value));
            }
        }
    }
}
