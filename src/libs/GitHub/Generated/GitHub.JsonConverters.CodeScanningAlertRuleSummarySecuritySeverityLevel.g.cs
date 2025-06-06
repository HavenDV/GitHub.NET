#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeScanningAlertRuleSummarySecuritySeverityLevelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.CodeScanningAlertRuleSummarySecuritySeverityLevel>
    {
        /// <inheritdoc />
        public override global::GitHub.CodeScanningAlertRuleSummarySecuritySeverityLevel Read(
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
                        return global::GitHub.CodeScanningAlertRuleSummarySecuritySeverityLevelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.CodeScanningAlertRuleSummarySecuritySeverityLevel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.CodeScanningAlertRuleSummarySecuritySeverityLevel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.CodeScanningAlertRuleSummarySecuritySeverityLevel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.CodeScanningAlertRuleSummarySecuritySeverityLevelExtensions.ToValueString(value));
        }
    }
}
