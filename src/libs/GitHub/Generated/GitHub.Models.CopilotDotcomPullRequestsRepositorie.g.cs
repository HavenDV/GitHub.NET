
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CopilotDotcomPullRequestsRepositorie
    {
        /// <summary>
        /// Repository name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The number of users who generated pull request summaries using Copilot for Pull Requests in the given repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_engaged_users")]
        public int? TotalEngagedUsers { get; set; }

        /// <summary>
        /// List of model metrics for custom models and the default model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::GitHub.CopilotDotcomPullRequestsRepositorieModel>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotDotcomPullRequestsRepositorie" /> class.
        /// </summary>
        /// <param name="name">
        /// Repository name
        /// </param>
        /// <param name="totalEngagedUsers">
        /// The number of users who generated pull request summaries using Copilot for Pull Requests in the given repository.
        /// </param>
        /// <param name="models">
        /// List of model metrics for custom models and the default model.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotDotcomPullRequestsRepositorie(
            string? name,
            int? totalEngagedUsers,
            global::System.Collections.Generic.IList<global::GitHub.CopilotDotcomPullRequestsRepositorieModel>? models)
        {
            this.Name = name;
            this.TotalEngagedUsers = totalEngagedUsers;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotDotcomPullRequestsRepositorie" /> class.
        /// </summary>
        public CopilotDotcomPullRequestsRepositorie()
        {
        }
    }
}