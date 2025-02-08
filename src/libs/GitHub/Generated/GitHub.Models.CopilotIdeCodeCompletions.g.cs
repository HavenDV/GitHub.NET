
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Usage metrics for Copilot editor code completions in the IDE.
    /// </summary>
    public sealed partial class CopilotIdeCodeCompletions
    {
        /// <summary>
        /// Number of users who accepted at least one Copilot code suggestion, across all active editors. Includes both full and partial acceptances.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_engaged_users")]
        public int? TotalEngagedUsers { get; set; }

        /// <summary>
        /// Code completion metrics for active languages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::GitHub.CopilotIdeCodeCompletionsLanguage>? Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editors")]
        public global::System.Collections.Generic.IList<global::GitHub.CopilotIdeCodeCompletionsEditor>? Editors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeCodeCompletions" /> class.
        /// </summary>
        /// <param name="totalEngagedUsers">
        /// Number of users who accepted at least one Copilot code suggestion, across all active editors. Includes both full and partial acceptances.
        /// </param>
        /// <param name="languages">
        /// Code completion metrics for active languages.
        /// </param>
        /// <param name="editors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotIdeCodeCompletions(
            int? totalEngagedUsers,
            global::System.Collections.Generic.IList<global::GitHub.CopilotIdeCodeCompletionsLanguage>? languages,
            global::System.Collections.Generic.IList<global::GitHub.CopilotIdeCodeCompletionsEditor>? editors)
        {
            this.TotalEngagedUsers = totalEngagedUsers;
            this.Languages = languages;
            this.Editors = editors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeCodeCompletions" /> class.
        /// </summary>
        public CopilotIdeCodeCompletions()
        {
        }
    }
}