
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Copilot usage metrics for a given day.
    /// </summary>
    public sealed partial class CopilotUsageMetricsDay
    {
        /// <summary>
        /// The date for which the usage metrics are aggregated, in `YYYY-MM-DD` format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// The total number of Copilot users with activity belonging to any Copilot feature, globally, for the given day. Includes passive activity such as receiving a code suggestion, as well as engagement activity such as accepting a code suggestion or prompting chat. Does not include authentication events. Is not limited to the individual features detailed on the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_active_users")]
        public int? TotalActiveUsers { get; set; }

        /// <summary>
        /// The total number of Copilot users who engaged with any Copilot feature, for the given day. Examples include but are not limited to accepting a code suggestion, prompting Copilot chat, or triggering a PR Summary. Does not include authentication events. Is not limited to the individual features detailed on the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_engaged_users")]
        public int? TotalEngagedUsers { get; set; }

        /// <summary>
        /// Usage metrics for Copilot editor code completions in the IDE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copilot_ide_code_completions")]
        public global::GitHub.CopilotIdeCodeCompletions? CopilotIdeCodeCompletions { get; set; }

        /// <summary>
        /// Usage metrics for Copilot Chat in the IDE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copilot_ide_chat")]
        public global::GitHub.CopilotIdeChat? CopilotIdeChat { get; set; }

        /// <summary>
        /// Usage metrics for Copilot Chat in GitHub.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copilot_dotcom_chat")]
        public global::GitHub.CopilotDotcomChat? CopilotDotcomChat { get; set; }

        /// <summary>
        /// Usage metrics for Copilot for pull requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copilot_dotcom_pull_requests")]
        public global::GitHub.CopilotDotcomPullRequests? CopilotDotcomPullRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotUsageMetricsDay" /> class.
        /// </summary>
        /// <param name="date">
        /// The date for which the usage metrics are aggregated, in `YYYY-MM-DD` format.
        /// </param>
        /// <param name="totalActiveUsers">
        /// The total number of Copilot users with activity belonging to any Copilot feature, globally, for the given day. Includes passive activity such as receiving a code suggestion, as well as engagement activity such as accepting a code suggestion or prompting chat. Does not include authentication events. Is not limited to the individual features detailed on the endpoint.
        /// </param>
        /// <param name="totalEngagedUsers">
        /// The total number of Copilot users who engaged with any Copilot feature, for the given day. Examples include but are not limited to accepting a code suggestion, prompting Copilot chat, or triggering a PR Summary. Does not include authentication events. Is not limited to the individual features detailed on the endpoint.
        /// </param>
        /// <param name="copilotIdeCodeCompletions">
        /// Usage metrics for Copilot editor code completions in the IDE.
        /// </param>
        /// <param name="copilotIdeChat">
        /// Usage metrics for Copilot Chat in the IDE.
        /// </param>
        /// <param name="copilotDotcomChat">
        /// Usage metrics for Copilot Chat in GitHub.com
        /// </param>
        /// <param name="copilotDotcomPullRequests">
        /// Usage metrics for Copilot for pull requests.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotUsageMetricsDay(
            global::System.DateTime date,
            int? totalActiveUsers,
            int? totalEngagedUsers,
            global::GitHub.CopilotIdeCodeCompletions? copilotIdeCodeCompletions,
            global::GitHub.CopilotIdeChat? copilotIdeChat,
            global::GitHub.CopilotDotcomChat? copilotDotcomChat,
            global::GitHub.CopilotDotcomPullRequests? copilotDotcomPullRequests)
        {
            this.Date = date;
            this.TotalActiveUsers = totalActiveUsers;
            this.TotalEngagedUsers = totalEngagedUsers;
            this.CopilotIdeCodeCompletions = copilotIdeCodeCompletions;
            this.CopilotIdeChat = copilotIdeChat;
            this.CopilotDotcomChat = copilotDotcomChat;
            this.CopilotDotcomPullRequests = copilotDotcomPullRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotUsageMetricsDay" /> class.
        /// </summary>
        public CopilotUsageMetricsDay()
        {
        }
    }
}