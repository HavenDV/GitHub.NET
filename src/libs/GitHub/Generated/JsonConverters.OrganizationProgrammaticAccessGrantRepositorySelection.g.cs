#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class OrganizationProgrammaticAccessGrantRepositorySelectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.OrganizationProgrammaticAccessGrantRepositorySelection>
    {
        /// <inheritdoc />
        public override global::GitHub.OrganizationProgrammaticAccessGrantRepositorySelection Read(
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
                        return global::GitHub.OrganizationProgrammaticAccessGrantRepositorySelectionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.OrganizationProgrammaticAccessGrantRepositorySelection)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.OrganizationProgrammaticAccessGrantRepositorySelection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.OrganizationProgrammaticAccessGrantRepositorySelectionExtensions.ToValueString(value));
        }
    }
}
