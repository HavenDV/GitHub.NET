
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Usage metrics for a given language for the given editor for Copilot code completions.
    /// </summary>
    public sealed partial class CopilotIdeCodeCompletionsLanguage
    {
        /// <summary>
        /// Name of the language used for Copilot code completion suggestions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Number of users who accepted at least one Copilot code completion suggestion for the given language. Includes both full and partial acceptances.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_engaged_users")]
        public int? TotalEngagedUsers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeCodeCompletionsLanguage" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the language used for Copilot code completion suggestions.
        /// </param>
        /// <param name="totalEngagedUsers">
        /// Number of users who accepted at least one Copilot code completion suggestion for the given language. Includes both full and partial acceptances.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotIdeCodeCompletionsLanguage(
            string? name,
            int? totalEngagedUsers)
        {
            this.Name = name;
            this.TotalEngagedUsers = totalEngagedUsers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeCodeCompletionsLanguage" /> class.
        /// </summary>
        public CopilotIdeCodeCompletionsLanguage()
        {
        }
    }
}