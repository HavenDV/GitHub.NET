
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Usage metrics for a given language for the given editor for Copilot code completions.
    /// </summary>
    public sealed partial class CopilotIdeCodeCompletionsEditorModelLanguage
    {
        /// <summary>
        /// Name of the language used for Copilot code completion suggestions, for the given editor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Number of users who accepted at least one Copilot code completion suggestion for the given editor, for the given language. Includes both full and partial acceptances.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_engaged_users")]
        public int? TotalEngagedUsers { get; set; }

        /// <summary>
        /// The number of Copilot code suggestions generated for the given editor, for the given language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_code_suggestions")]
        public int? TotalCodeSuggestions { get; set; }

        /// <summary>
        /// The number of Copilot code suggestions accepted for the given editor, for the given language. Includes both full and partial acceptances.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_code_acceptances")]
        public int? TotalCodeAcceptances { get; set; }

        /// <summary>
        /// The number of lines of code suggested by Copilot code completions for the given editor, for the given language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_code_lines_suggested")]
        public int? TotalCodeLinesSuggested { get; set; }

        /// <summary>
        /// The number of lines of code accepted from Copilot code suggestions for the given editor, for the given language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_code_lines_accepted")]
        public int? TotalCodeLinesAccepted { get; set; }

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
        public static global::GitHub.CopilotIdeCodeCompletionsEditorModelLanguage? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::GitHub.CopilotIdeCodeCompletionsEditorModelLanguage),
                jsonSerializerContext) as global::GitHub.CopilotIdeCodeCompletionsEditorModelLanguage;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::GitHub.CopilotIdeCodeCompletionsEditorModelLanguage? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::GitHub.CopilotIdeCodeCompletionsEditorModelLanguage>(
                json,
                jsonSerializerOptions);
        }

    }
}