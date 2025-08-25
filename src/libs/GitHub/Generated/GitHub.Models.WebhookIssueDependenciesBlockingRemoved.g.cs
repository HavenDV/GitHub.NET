
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookIssueDependenciesBlockingRemoved
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssueDependenciesBlockingRemovedActionJsonConverter))]
        public global::GitHub.WebhookIssueDependenciesBlockingRemovedAction Action { get; set; }

        /// <summary>
        /// The ID of the blocked issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_issue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BlockedIssueId { get; set; }

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_issue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.Issue BlockedIssue { get; set; }

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_issue_repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.Repository BlockedIssueRepo { get; set; }

        /// <summary>
        /// The ID of the blocking issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking_issue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BlockingIssueId { get; set; }

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking_issue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.Issue BlockingIssue { get; set; }

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        public global::GitHub.SimpleInstallation? Installation { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.OrganizationSimpleWebhooks Organization { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.RepositoryWebhooks Repository { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SimpleUser Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssueDependenciesBlockingRemoved" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="blockedIssueId">
        /// The ID of the blocked issue.
        /// </param>
        /// <param name="blockedIssue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        /// <param name="blockedIssueRepo">
        /// A repository on GitHub.
        /// </param>
        /// <param name="blockingIssueId">
        /// The ID of the blocking issue.
        /// </param>
        /// <param name="blockingIssue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        /// <param name="installation">
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </param>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookIssueDependenciesBlockingRemoved(
            double blockedIssueId,
            global::GitHub.Issue blockedIssue,
            global::GitHub.Repository blockedIssueRepo,
            double blockingIssueId,
            global::GitHub.Issue blockingIssue,
            global::GitHub.OrganizationSimpleWebhooks organization,
            global::GitHub.RepositoryWebhooks repository,
            global::GitHub.SimpleUser sender,
            global::GitHub.WebhookIssueDependenciesBlockingRemovedAction action,
            global::GitHub.SimpleInstallation? installation)
        {
            this.BlockedIssueId = blockedIssueId;
            this.BlockedIssue = blockedIssue ?? throw new global::System.ArgumentNullException(nameof(blockedIssue));
            this.BlockedIssueRepo = blockedIssueRepo ?? throw new global::System.ArgumentNullException(nameof(blockedIssueRepo));
            this.BlockingIssueId = blockingIssueId;
            this.BlockingIssue = blockingIssue ?? throw new global::System.ArgumentNullException(nameof(blockingIssue));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Action = action;
            this.Installation = installation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssueDependenciesBlockingRemoved" /> class.
        /// </summary>
        public WebhookIssueDependenciesBlockingRemoved()
        {
        }
    }
}