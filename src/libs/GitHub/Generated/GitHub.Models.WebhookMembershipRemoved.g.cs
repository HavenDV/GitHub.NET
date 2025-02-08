
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookMembershipRemoved
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookMembershipRemovedActionJsonConverter))]
        public global::GitHub.WebhookMembershipRemovedAction Action { get; set; }

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        public global::GitHub.EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        public global::GitHub.SimpleInstallation? Installation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhooksUser? Member { get; set; }

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
        public global::GitHub.RepositoryWebhooks? Repository { get; set; }

        /// <summary>
        /// The scope of the membership. Currently, can only be `team`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookMembershipRemovedScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookMembershipRemovedScope Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookMembershipRemovedSender? Sender { get; set; }

        /// <summary>
        /// Groups of organization members that gives permissions on specified repositories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhooksTeam Team { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMembershipRemoved" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="enterprise">
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </param>
        /// <param name="installation">
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </param>
        /// <param name="member"></param>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="scope">
        /// The scope of the membership. Currently, can only be `team`.
        /// </param>
        /// <param name="sender"></param>
        /// <param name="team">
        /// Groups of organization members that gives permissions on specified repositories.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookMembershipRemoved(
            global::GitHub.WebhooksUser? member,
            global::GitHub.OrganizationSimpleWebhooks organization,
            global::GitHub.WebhookMembershipRemovedScope scope,
            global::GitHub.WebhookMembershipRemovedSender? sender,
            global::GitHub.WebhooksTeam team,
            global::GitHub.WebhookMembershipRemovedAction action,
            global::GitHub.EnterpriseWebhooks? enterprise,
            global::GitHub.SimpleInstallation? installation,
            global::GitHub.RepositoryWebhooks? repository)
        {
            this.Member = member ?? throw new global::System.ArgumentNullException(nameof(member));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Scope = scope;
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Team = team ?? throw new global::System.ArgumentNullException(nameof(team));
            this.Action = action;
            this.Enterprise = enterprise;
            this.Installation = installation;
            this.Repository = repository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMembershipRemoved" /> class.
        /// </summary>
        public WebhookMembershipRemoved()
        {
        }
    }
}