
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Information about the seat breakdown and policies set for an organization with a Copilot Business or Copilot Enterprise subscription.
    /// </summary>
    public sealed partial class CopilotOrganizationDetails
    {
        /// <summary>
        /// The breakdown of Copilot Business seats for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seat_breakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CopilotSeatBreakdown SeatBreakdown { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing Copilot to make suggestions that match public code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_code_suggestions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CopilotOrganizationDetailsPublicCodeSuggestionsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CopilotOrganizationDetailsPublicCodeSuggestions PublicCodeSuggestions { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot Chat within their editor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ide_chat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CopilotOrganizationDetailsIdeChatJsonConverter))]
        public global::GitHub.CopilotOrganizationDetailsIdeChat? IdeChat { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot features within github.com.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_chat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CopilotOrganizationDetailsPlatformChatJsonConverter))]
        public global::GitHub.CopilotOrganizationDetailsPlatformChat? PlatformChat { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot within their CLI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cli")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CopilotOrganizationDetailsCliJsonConverter))]
        public global::GitHub.CopilotOrganizationDetailsCli? Cli { get; set; }

        /// <summary>
        /// The mode of assigning new seats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seat_management_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CopilotOrganizationDetailsSeatManagementSettingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CopilotOrganizationDetailsSeatManagementSetting SeatManagementSetting { get; set; }

        /// <summary>
        /// The Copilot plan of the organization, or the parent enterprise, when applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CopilotOrganizationDetailsPlanTypeJsonConverter))]
        public global::GitHub.CopilotOrganizationDetailsPlanType? PlanType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::GitHub.CopilotOrganizationDetails? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::GitHub.CopilotOrganizationDetails),
                jsonSerializerContext) as global::GitHub.CopilotOrganizationDetails;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::GitHub.CopilotOrganizationDetails? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::GitHub.CopilotOrganizationDetails>(
                json,
                jsonSerializerOptions);
        }

    }
}