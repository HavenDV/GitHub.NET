
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryDispatchSample
    {
        /// <summary>
        /// The `event_type` that was specified in the `POST /repos/{owner}/{repo}/dispatches` request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Branch { get; set; }

        /// <summary>
        /// The `client_payload` that was specified in the `POST /repos/{owner}/{repo}/dispatches` request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? ClientPayload { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SimpleInstallation Installation { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SimpleUser Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryDispatchSample" /> class.
        /// </summary>
        /// <param name="action">
        /// The `event_type` that was specified in the `POST /repos/{owner}/{repo}/dispatches` request body.
        /// </param>
        /// <param name="branch"></param>
        /// <param name="clientPayload">
        /// The `client_payload` that was specified in the `POST /repos/{owner}/{repo}/dispatches` request body.
        /// </param>
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
        public WebhookRepositoryDispatchSample(
            string action,
            string branch,
            object? clientPayload,
            global::GitHub.SimpleInstallation installation,
            global::GitHub.RepositoryWebhooks repository,
            global::GitHub.SimpleUser sender,
            global::GitHub.EnterpriseWebhooks? enterprise,
            global::GitHub.OrganizationSimpleWebhooks? organization)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Branch = branch ?? throw new global::System.ArgumentNullException(nameof(branch));
            this.ClientPayload = clientPayload ?? throw new global::System.ArgumentNullException(nameof(clientPayload));
            this.Installation = installation ?? throw new global::System.ArgumentNullException(nameof(installation));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Enterprise = enterprise;
            this.Organization = organization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryDispatchSample" /> class.
        /// </summary>
        public WebhookRepositoryDispatchSample()
        {
        }
    }
}