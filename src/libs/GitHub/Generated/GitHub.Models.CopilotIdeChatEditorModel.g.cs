
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CopilotIdeChatEditorModel
    {
        /// <summary>
        /// Name of the model used for Copilot Chat. If the default model is used will appear as 'default'.
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
        /// The number of users who prompted Copilot Chat in the given editor and model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_engaged_users")]
        public int? TotalEngagedUsers { get; set; }

        /// <summary>
        /// The total number of chats initiated by users in the given editor and model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_chats")]
        public int? TotalChats { get; set; }

        /// <summary>
        /// The number of times users accepted a code suggestion from Copilot Chat using the 'Insert Code' UI element, for the given editor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_chat_insertion_events")]
        public int? TotalChatInsertionEvents { get; set; }

        /// <summary>
        /// The number of times users copied a code suggestion from Copilot Chat using the keyboard, or the 'Copy' UI element, for the given editor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_chat_copy_events")]
        public int? TotalChatCopyEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeChatEditorModel" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the model used for Copilot Chat. If the default model is used will appear as 'default'.
        /// </param>
        /// <param name="isCustomModel">
        /// Indicates whether a model is custom or default.
        /// </param>
        /// <param name="customModelTrainingDate">
        /// The training date for the custom model.
        /// </param>
        /// <param name="totalEngagedUsers">
        /// The number of users who prompted Copilot Chat in the given editor and model.
        /// </param>
        /// <param name="totalChats">
        /// The total number of chats initiated by users in the given editor and model.
        /// </param>
        /// <param name="totalChatInsertionEvents">
        /// The number of times users accepted a code suggestion from Copilot Chat using the 'Insert Code' UI element, for the given editor.
        /// </param>
        /// <param name="totalChatCopyEvents">
        /// The number of times users copied a code suggestion from Copilot Chat using the keyboard, or the 'Copy' UI element, for the given editor.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotIdeChatEditorModel(
            string? name,
            bool? isCustomModel,
            string? customModelTrainingDate,
            int? totalEngagedUsers,
            int? totalChats,
            int? totalChatInsertionEvents,
            int? totalChatCopyEvents)
        {
            this.Name = name;
            this.IsCustomModel = isCustomModel;
            this.CustomModelTrainingDate = customModelTrainingDate;
            this.TotalEngagedUsers = totalEngagedUsers;
            this.TotalChats = totalChats;
            this.TotalChatInsertionEvents = totalChatInsertionEvents;
            this.TotalChatCopyEvents = totalChatCopyEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeChatEditorModel" /> class.
        /// </summary>
        public CopilotIdeChatEditorModel()
        {
        }
    }
}