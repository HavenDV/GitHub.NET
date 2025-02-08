
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Copilot code completion metrics for active editors.
    /// </summary>
    public sealed partial class CopilotIdeCodeCompletionsEditor
    {
        /// <summary>
        /// Name of the given editor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Number of users who accepted at least one Copilot code completion suggestion for the given editor. Includes both full and partial acceptances.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_engaged_users")]
        public int? TotalEngagedUsers { get; set; }

        /// <summary>
        /// List of model metrics for custom models and the default model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::GitHub.CopilotIdeCodeCompletionsEditorModel>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeCodeCompletionsEditor" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the given editor.
        /// </param>
        /// <param name="totalEngagedUsers">
        /// Number of users who accepted at least one Copilot code completion suggestion for the given editor. Includes both full and partial acceptances.
        /// </param>
        /// <param name="models">
        /// List of model metrics for custom models and the default model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotIdeCodeCompletionsEditor(
            string? name,
            int? totalEngagedUsers,
            global::System.Collections.Generic.IList<global::GitHub.CopilotIdeCodeCompletionsEditorModel>? models)
        {
            this.Name = name;
            this.TotalEngagedUsers = totalEngagedUsers;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeCodeCompletionsEditor" /> class.
        /// </summary>
        public CopilotIdeCodeCompletionsEditor()
        {
        }
    }
}