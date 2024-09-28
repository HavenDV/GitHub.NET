
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPing
    {
        /// <summary>
        /// The webhook that is being pinged
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook")]
        public global::GitHub.WebhookPingHook? Hook { get; set; }

        /// <summary>
        /// The ID of the webhook that triggered the ping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_id")]
        public int HookId { get; set; }

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
        public global::GitHub.RepositoryWebhooks? Repository { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        public global::GitHub.SimpleUser? Sender { get; set; }

        /// <summary>
        /// Random string of GitHub zen.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zen")]
        public string? Zen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}