
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Usage metrics for Copilot for pull requests.
    /// </summary>
    public sealed partial class CopilotDotcomPullRequests
    {
        /// <summary>
        /// The number of users who used Copilot for Pull Requests on github.com to generate a pull request summary at least once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_engaged_users")]
        public int? TotalEngagedUsers { get; set; }

        /// <summary>
        /// Repositories in which users used Copilot for Pull Requests to generate pull request summaries
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        public global::System.Collections.Generic.IList<global::GitHub.CopilotDotcomPullRequestsRepositorie>? Repositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotDotcomPullRequests" /> class.
        /// </summary>
        /// <param name="totalEngagedUsers">
        /// The number of users who used Copilot for Pull Requests on github.com to generate a pull request summary at least once.
        /// </param>
        /// <param name="repositories">
        /// Repositories in which users used Copilot for Pull Requests to generate pull request summaries
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotDotcomPullRequests(
            int? totalEngagedUsers,
            global::System.Collections.Generic.IList<global::GitHub.CopilotDotcomPullRequestsRepositorie>? repositories)
        {
            this.TotalEngagedUsers = totalEngagedUsers;
            this.Repositories = repositories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotDotcomPullRequests" /> class.
        /// </summary>
        public CopilotDotcomPullRequests()
        {
        }
    }
}