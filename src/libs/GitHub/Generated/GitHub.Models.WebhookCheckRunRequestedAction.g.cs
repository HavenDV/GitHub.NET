
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCheckRunRequestedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckRunRequestedActionActionJsonConverter))]
        public global::GitHub.WebhookCheckRunRequestedActionAction Action { get; set; }

        /// <summary>
        /// A check performed on the code of a given code change
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_run")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CheckRunWithSimpleCheckSuite CheckRun { get; set; }

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
        public global::GitHub.OrganizationSimpleWebhooks? Organization { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.RepositoryWebhooks Repository { get; set; }

        /// <summary>
        /// The action requested by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_action")]
        public global::GitHub.WebhookCheckRunRequestedActionRequestedAction? RequestedAction { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookCheckRunRequestedAction" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="checkRun">
        /// A check performed on the code of a given code change
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
        /// <param name="requestedAction">
        /// The action requested by the user.
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookCheckRunRequestedAction(
            global::GitHub.CheckRunWithSimpleCheckSuite checkRun,
            global::GitHub.RepositoryWebhooks repository,
            global::GitHub.SimpleUser sender,
            global::GitHub.WebhookCheckRunRequestedActionAction action,
            global::GitHub.SimpleInstallation? installation,
            global::GitHub.OrganizationSimpleWebhooks? organization,
            global::GitHub.WebhookCheckRunRequestedActionRequestedAction? requestedAction)
        {
            this.CheckRun = checkRun ?? throw new global::System.ArgumentNullException(nameof(checkRun));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Action = action;
            this.Installation = installation;
            this.Organization = organization;
            this.RequestedAction = requestedAction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckRunRequestedAction" /> class.
        /// </summary>
        public WebhookCheckRunRequestedAction()
        {
        }
    }
}