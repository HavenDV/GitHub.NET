
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookSecretScanningScanCompleted
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookSecretScanningScanCompletedActionJsonConverter))]
        public global::GitHub.WebhookSecretScanningScanCompletedAction Action { get; set; }

        /// <summary>
        /// What type of scan was completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookSecretScanningScanCompletedTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookSecretScanningScanCompletedType Type { get; set; }

        /// <summary>
        /// What type of content was scanned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookSecretScanningScanCompletedSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookSecretScanningScanCompletedSource Source { get; set; }

        /// <summary>
        /// The time that the alert was resolved in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// The time that the alert was resolved in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CompletedAt { get; set; }

        /// <summary>
        /// List of patterns that were updated. This will be empty for normal backfill scans or custom pattern updates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_types")]
        public global::System.Collections.Generic.IList<string>? SecretTypes { get; set; }

        /// <summary>
        /// If the scan was triggered by a custom pattern update, this will be the name of the pattern that was updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_pattern_name")]
        public string? CustomPatternName { get; set; }

        /// <summary>
        /// If the scan was triggered by a custom pattern update, this will be the scope of the pattern that was updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_pattern_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookSecretScanningScanCompletedCustomPatternScopeJsonConverter))]
        public global::GitHub.WebhookSecretScanningScanCompletedCustomPatternScope? CustomPatternScope { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::GitHub.RepositoryWebhooks? Repository { get; set; }

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
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::GitHub.OrganizationSimpleWebhooks? Organization { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookSecretScanningScanCompleted" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="type">
        /// What type of scan was completed
        /// </param>
        /// <param name="source">
        /// What type of content was scanned
        /// </param>
        /// <param name="startedAt">
        /// The time that the alert was resolved in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="completedAt">
        /// The time that the alert was resolved in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="secretTypes">
        /// List of patterns that were updated. This will be empty for normal backfill scans or custom pattern updates
        /// </param>
        /// <param name="customPatternName">
        /// If the scan was triggered by a custom pattern update, this will be the name of the pattern that was updated
        /// </param>
        /// <param name="customPatternScope">
        /// If the scan was triggered by a custom pattern update, this will be the scope of the pattern that was updated
        /// </param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
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
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSecretScanningScanCompleted(
            global::GitHub.WebhookSecretScanningScanCompletedType type,
            global::GitHub.WebhookSecretScanningScanCompletedSource source,
            global::System.DateTime startedAt,
            global::System.DateTime completedAt,
            global::GitHub.WebhookSecretScanningScanCompletedAction action,
            global::System.Collections.Generic.IList<string>? secretTypes,
            string? customPatternName,
            global::GitHub.WebhookSecretScanningScanCompletedCustomPatternScope? customPatternScope,
            global::GitHub.RepositoryWebhooks? repository,
            global::GitHub.EnterpriseWebhooks? enterprise,
            global::GitHub.SimpleInstallation? installation,
            global::GitHub.OrganizationSimpleWebhooks? organization,
            global::GitHub.SimpleUser? sender)
        {
            this.Type = type;
            this.Source = source;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Action = action;
            this.SecretTypes = secretTypes;
            this.CustomPatternName = customPatternName;
            this.CustomPatternScope = customPatternScope;
            this.Repository = repository;
            this.Enterprise = enterprise;
            this.Installation = installation;
            this.Organization = organization;
            this.Sender = sender;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSecretScanningScanCompleted" /> class.
        /// </summary>
        public WebhookSecretScanningScanCompleted()
        {
        }
    }
}