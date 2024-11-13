
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Copilot Chat metrics, for active editors.
    /// </summary>
    public sealed partial class CopilotIdeChatEditor
    {
        /// <summary>
        /// Name of the given editor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The number of users who prompted Copilot Chat in the specified editor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_engaged_users")]
        public int? TotalEngagedUsers { get; set; }

        /// <summary>
        /// List of model metrics for custom models and the default model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::GitHub.CopilotIdeChatEditorModel>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeChatEditor" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the given editor.
        /// </param>
        /// <param name="totalEngagedUsers">
        /// The number of users who prompted Copilot Chat in the specified editor.
        /// </param>
        /// <param name="models">
        /// List of model metrics for custom models and the default model.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotIdeChatEditor(
            string? name,
            int? totalEngagedUsers,
            global::System.Collections.Generic.IList<global::GitHub.CopilotIdeChatEditorModel>? models)
        {
            this.Name = name;
            this.TotalEngagedUsers = totalEngagedUsers;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeChatEditor" /> class.
        /// </summary>
        public CopilotIdeChatEditor()
        {
        }
    }
}