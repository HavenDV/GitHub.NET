
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookDiscussionUnanswered
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDiscussionUnansweredActionJsonConverter))]
        public global::GitHub.WebhookDiscussionUnansweredAction Action { get; set; }

        /// <summary>
        /// A Discussion in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.Discussion Discussion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_answer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhooksAnswer OldAnswer { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookDiscussionUnanswered" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="discussion">
        /// A Discussion in a repository.
        /// </param>
        /// <param name="oldAnswer"></param>
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookDiscussionUnanswered(
            global::GitHub.Discussion discussion,
            global::GitHub.WebhooksAnswer oldAnswer,
            global::GitHub.RepositoryWebhooks repository,
            global::GitHub.WebhookDiscussionUnansweredAction action,
            global::GitHub.OrganizationSimpleWebhooks? organization,
            global::GitHub.SimpleUser? sender)
        {
            this.Discussion = discussion ?? throw new global::System.ArgumentNullException(nameof(discussion));
            this.OldAnswer = oldAnswer ?? throw new global::System.ArgumentNullException(nameof(oldAnswer));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Action = action;
            this.Organization = organization;
            this.Sender = sender;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDiscussionUnanswered" /> class.
        /// </summary>
        public WebhookDiscussionUnanswered()
        {
        }
    }
}