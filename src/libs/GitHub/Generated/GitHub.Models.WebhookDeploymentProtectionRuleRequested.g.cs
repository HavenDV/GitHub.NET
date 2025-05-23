
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDeploymentProtectionRuleRequested
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentProtectionRuleRequestedActionJsonConverter))]
        public global::GitHub.WebhookDeploymentProtectionRuleRequestedAction? Action { get; set; }

        /// <summary>
        /// The name of the environment that has the deployment protection rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// The event that triggered the deployment protection rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        /// The URL to review the deployment protection rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_callback_url")]
        public string? DeploymentCallbackUrl { get; set; }

        /// <summary>
        /// A request for a specific ref(branch,sha,tag) to be deployed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        public global::GitHub.Deployment? Deployment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        public global::System.Collections.Generic.IList<global::GitHub.PullRequest>? PullRequests { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::GitHub.RepositoryWebhooks? Repository { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::GitHub.OrganizationSimpleWebhooks? Organization { get; set; }

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        public global::GitHub.SimpleInstallation? Installation { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        public global::GitHub.SimpleUser? Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentProtectionRuleRequested" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="environment">
        /// The name of the environment that has the deployment protection rule.
        /// </param>
        /// <param name="event">
        /// The event that triggered the deployment protection rule.
        /// </param>
        /// <param name="deploymentCallbackUrl">
        /// The URL to review the deployment protection rule.
        /// </param>
        /// <param name="deployment">
        /// A request for a specific ref(branch,sha,tag) to be deployed
        /// </param>
        /// <param name="pullRequests"></param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="installation">
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDeploymentProtectionRuleRequested(
            global::GitHub.WebhookDeploymentProtectionRuleRequestedAction? action,
            string? environment,
            string? @event,
            string? deploymentCallbackUrl,
            global::GitHub.Deployment? deployment,
            global::System.Collections.Generic.IList<global::GitHub.PullRequest>? pullRequests,
            global::GitHub.RepositoryWebhooks? repository,
            global::GitHub.OrganizationSimpleWebhooks? organization,
            global::GitHub.SimpleInstallation? installation,
            global::GitHub.SimpleUser? sender)
        {
            this.Action = action;
            this.Environment = environment;
            this.Event = @event;
            this.DeploymentCallbackUrl = deploymentCallbackUrl;
            this.Deployment = deployment;
            this.PullRequests = pullRequests;
            this.Repository = repository;
            this.Organization = organization;
            this.Installation = installation;
            this.Sender = sender;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentProtectionRuleRequested" /> class.
        /// </summary>
        public WebhookDeploymentProtectionRuleRequested()
        {
        }
    }
}