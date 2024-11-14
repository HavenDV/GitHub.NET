#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class UserRoleAssignmentAssignmentNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.UserRoleAssignmentAssignment?>
    {
        /// <inheritdoc />
        public override global::GitHub.UserRoleAssignmentAssignment? Read(
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
                        return global::GitHub.UserRoleAssignmentAssignmentExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.UserRoleAssignmentAssignment)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.UserRoleAssignmentAssignment? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.UserRoleAssignmentAssignmentExtensions.ToValueString(value.Value));
            }
        }
    }
}
