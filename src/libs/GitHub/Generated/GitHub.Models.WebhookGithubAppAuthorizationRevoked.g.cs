
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookGithubAppAuthorizationRevoked
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookGithubAppAuthorizationRevokedActionJsonConverter))]
        public global::GitHub.WebhookGithubAppAuthorizationRevokedAction Action { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookGithubAppAuthorizationRevoked" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookGithubAppAuthorizationRevoked(
            global::GitHub.SimpleUser sender,
            global::GitHub.WebhookGithubAppAuthorizationRevokedAction action)
        {
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGithubAppAuthorizationRevoked" /> class.
        /// </summary>
        public WebhookGithubAppAuthorizationRevoked()
        {
        }
    }
}