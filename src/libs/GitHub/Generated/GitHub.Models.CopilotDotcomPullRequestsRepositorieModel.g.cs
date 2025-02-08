
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CopilotDotcomPullRequestsRepositorieModel
    {
        /// <summary>
        /// Name of the model used for Copilot pull request summaries. If the default model is used will appear as 'default'.
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
        /// The number of pull request summaries generated using Copilot for Pull Requests in the given repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pr_summaries_created")]
        public int? TotalPrSummariesCreated { get; set; }

        /// <summary>
        /// The number of users who generated pull request summaries using Copilot for Pull Requests in the given repository and model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_engaged_users")]
        public int? TotalEngagedUsers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotDotcomPullRequestsRepositorieModel" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the model used for Copilot pull request summaries. If the default model is used will appear as 'default'.
        /// </param>
        /// <param name="isCustomModel">
        /// Indicates whether a model is custom or default.
        /// </param>
        /// <param name="customModelTrainingDate">
        /// The training date for the custom model.
        /// </param>
        /// <param name="totalPrSummariesCreated">
        /// The number of pull request summaries generated using Copilot for Pull Requests in the given repository.
        /// </param>
        /// <param name="totalEngagedUsers">
        /// The number of users who generated pull request summaries using Copilot for Pull Requests in the given repository and model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotDotcomPullRequestsRepositorieModel(
            string? name,
            bool? isCustomModel,
            string? customModelTrainingDate,
            int? totalPrSummariesCreated,
            int? totalEngagedUsers)
        {
            this.Name = name;
            this.IsCustomModel = isCustomModel;
            this.CustomModelTrainingDate = customModelTrainingDate;
            this.TotalPrSummariesCreated = totalPrSummariesCreated;
            this.TotalEngagedUsers = totalEngagedUsers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotDotcomPullRequestsRepositorieModel" /> class.
        /// </summary>
        public CopilotDotcomPullRequestsRepositorieModel()
        {
        }
    }
}