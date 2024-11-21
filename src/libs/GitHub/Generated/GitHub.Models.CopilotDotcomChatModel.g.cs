
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CopilotDotcomChatModel
    {
        /// <summary>
        /// Name of the model used for Copilot code completion suggestions. If the default model is used will appear as 'default'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Indicates whether a model is custom or default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_custom_model")]
        public bool? IsCustomModel { get; set; }

        /// <summary>
        /// The training date for the custom model (if applicable).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_model_training_date")]
        public string? CustomModelTrainingDate { get; set; }

        /// <summary>
        /// Total number of users who prompted Copilot Chat on github.com at least once for each model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_engaged_users")]
        public int? TotalEngagedUsers { get; set; }

        /// <summary>
        /// Total number of chats initiated by users on github.com.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_chats")]
        public int? TotalChats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotDotcomChatModel" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the model used for Copilot code completion suggestions. If the default model is used will appear as 'default'.
        /// </param>
        /// <param name="isCustomModel">
        /// Indicates whether a model is custom or default.
        /// </param>
        /// <param name="customModelTrainingDate">
        /// The training date for the custom model (if applicable).
        /// </param>
        /// <param name="totalEngagedUsers">
        /// Total number of users who prompted Copilot Chat on github.com at least once for each model.
        /// </param>
        /// <param name="totalChats">
        /// Total number of chats initiated by users on github.com.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotDotcomChatModel(
            string? name,
            bool? isCustomModel,
            string? customModelTrainingDate,
            int? totalEngagedUsers,
            int? totalChats)
        {
            this.Name = name;
            this.IsCustomModel = isCustomModel;
            this.CustomModelTrainingDate = customModelTrainingDate;
            this.TotalEngagedUsers = totalEngagedUsers;
            this.TotalChats = totalChats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotDotcomChatModel" /> class.
        /// </summary>
        public CopilotDotcomChatModel()
        {
        }
    }
}