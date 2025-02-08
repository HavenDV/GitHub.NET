
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
        /// Initializes a new instance of the <see cref="CopilotIdeCodeCompletionsEditorModelLanguage" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the language used for Copilot code completion suggestions, for the given editor.
        /// </param>
        /// <param name="totalEngagedUsers">
        /// Number of users who accepted at least one Copilot code completion suggestion for the given editor, for the given language. Includes both full and partial acceptances.
        /// </param>
        /// <param name="totalCodeSuggestions">
        /// The number of Copilot code suggestions generated for the given editor, for the given language.
        /// </param>
        /// <param name="totalCodeAcceptances">
        /// The number of Copilot code suggestions accepted for the given editor, for the given language. Includes both full and partial acceptances.
        /// </param>
        /// <param name="totalCodeLinesSuggested">
        /// The number of lines of code suggested by Copilot code completions for the given editor, for the given language.
        /// </param>
        /// <param name="totalCodeLinesAccepted">
        /// The number of lines of code accepted from Copilot code suggestions for the given editor, for the given language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotIdeCodeCompletionsEditorModelLanguage(
            string? name,
            int? totalEngagedUsers,
            int? totalCodeSuggestions,
            int? totalCodeAcceptances,
            int? totalCodeLinesSuggested,
            int? totalCodeLinesAccepted)
        {
            this.Name = name;
            this.TotalEngagedUsers = totalEngagedUsers;
            this.TotalCodeSuggestions = totalCodeSuggestions;
            this.TotalCodeAcceptances = totalCodeAcceptances;
            this.TotalCodeLinesSuggested = totalCodeLinesSuggested;
            this.TotalCodeLinesAccepted = totalCodeLinesAccepted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeCodeCompletionsEditorModelLanguage" /> class.
        /// </summary>
        public CopilotIdeCodeCompletionsEditorModelLanguage()
        {
        }
    }
}