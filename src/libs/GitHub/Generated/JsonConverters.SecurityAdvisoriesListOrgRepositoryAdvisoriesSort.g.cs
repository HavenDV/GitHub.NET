#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class SecurityAdvisoriesListOrgRepositoryAdvisoriesSortJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort>
    {
        /// <inheritdoc />
        public override global::GitHub.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort Read(
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
                        return global::GitHub.SecurityAdvisoriesListOrgRepositoryAdvisoriesSortExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.SecurityAdvisoriesListOrgRepositoryAdvisoriesSortExtensions.ToValueString(value));
        }
    }
}
