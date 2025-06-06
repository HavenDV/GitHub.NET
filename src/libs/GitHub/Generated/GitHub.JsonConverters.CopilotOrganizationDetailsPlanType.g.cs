#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class CopilotOrganizationDetailsPlanTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.CopilotOrganizationDetailsPlanType>
    {
        /// <inheritdoc />
        public override global::GitHub.CopilotOrganizationDetailsPlanType Read(
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
                        return global::GitHub.CopilotOrganizationDetailsPlanTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.CopilotOrganizationDetailsPlanType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.CopilotOrganizationDetailsPlanType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.CopilotOrganizationDetailsPlanType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.CopilotOrganizationDetailsPlanTypeExtensions.ToValueString(value));
        }
    }
}
