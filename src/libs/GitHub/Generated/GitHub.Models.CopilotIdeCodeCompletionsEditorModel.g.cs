
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CopilotIdeCodeCompletionsEditorModel
    {
        /// <summary>
        /// Name of the language used for Copilot code completion suggestions, for the given editor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Indicates whether a model is custom or default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_custom_model")]
        public bool? IsCustomModel { get; set; }

        /// <summary>
        /// The training date for the custom model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_model_training_date")]
        public string? CustomModelTrainingDate { get; set; }

        /// <summary>
        /// Number of users who accepted at least one Copilot code completion suggestion for the given editor, for the given language and model. Includes both full and partial acceptances.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_engaged_users")]
        public int? TotalEngagedUsers { get; set; }

        /// <summary>
        /// Code completion metrics for active languages, for the given editor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::GitHub.CopilotIdeCodeCompletionsEditorModelLanguage>? Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeCodeCompletionsEditorModel" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the language used for Copilot code completion suggestions, for the given editor.
        /// </param>
        /// <param name="isCustomModel">
        /// Indicates whether a model is custom or default.
        /// </param>
        /// <param name="customModelTrainingDate">
        /// The training date for the custom model.
        /// </param>
        /// <param name="totalEngagedUsers">
        /// Number of users who accepted at least one Copilot code completion suggestion for the given editor, for the given language and model. Includes both full and partial acceptances.
        /// </param>
        /// <param name="languages">
        /// Code completion metrics for active languages, for the given editor.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotIdeCodeCompletionsEditorModel(
            string? name,
            bool? isCustomModel,
            string? customModelTrainingDate,
            int? totalEngagedUsers,
            global::System.Collections.Generic.IList<global::GitHub.CopilotIdeCodeCompletionsEditorModelLanguage>? languages)
        {
            this.Name = name;
            this.IsCustomModel = isCustomModel;
            this.CustomModelTrainingDate = customModelTrainingDate;
            this.TotalEngagedUsers = totalEngagedUsers;
            this.Languages = languages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeCodeCompletionsEditorModel" /> class.
        /// </summary>
        public CopilotIdeCodeCompletionsEditorModel()
        {
        }
    }
}