
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPersonalAccessTokenRequestCancelled
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookPersonalAccessTokenRequestCancelledActionJsonConverter))]
        public global::GitHub.WebhookPersonalAccessTokenRequestCancelledAction Action { get; set; }

        /// <summary>
        /// Details of a Personal Access Token Request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personal_access_token_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.PersonalAccessTokenRequest PersonalAccessTokenRequest { get; set; }

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        public global::GitHub.EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.OrganizationSimpleWebhooks Organization { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SimpleUser Sender { get; set; }

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SimpleInstallation Installation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPersonalAccessTokenRequestCancelled" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="personalAccessTokenRequest">
        /// Details of a Personal Access Token Request.
        /// </param>
        /// <param name="enterprise">
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </param>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        /// <param name="installation">
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPersonalAccessTokenRequestCancelled(
            global::GitHub.PersonalAccessTokenRequest personalAccessTokenRequest,
            global::GitHub.OrganizationSimpleWebhooks organization,
            global::GitHub.SimpleUser sender,
            global::GitHub.SimpleInstallation installation,
            global::GitHub.WebhookPersonalAccessTokenRequestCancelledAction action,
            global::GitHub.EnterpriseWebhooks? enterprise)
        {
            this.PersonalAccessTokenRequest = personalAccessTokenRequest ?? throw new global::System.ArgumentNullException(nameof(personalAccessTokenRequest));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Installation = installation ?? throw new global::System.ArgumentNullException(nameof(installation));
            this.Action = action;
            this.Enterprise = enterprise;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPersonalAccessTokenRequestCancelled" /> class.
        /// </summary>
        public WebhookPersonalAccessTokenRequestCancelled()
        {
        }
    }
}