#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProjectsV2StatusUpdateStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.ProjectsV2StatusUpdateStatus>
    {
        /// <inheritdoc />
        public override global::GitHub.ProjectsV2StatusUpdateStatus Read(
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
                        return global::GitHub.ProjectsV2StatusUpdateStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.ProjectsV2StatusUpdateStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.ProjectsV2StatusUpdateStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.ProjectsV2StatusUpdateStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.ProjectsV2StatusUpdateStatusExtensions.ToValueString(value));
        }
    }
}
