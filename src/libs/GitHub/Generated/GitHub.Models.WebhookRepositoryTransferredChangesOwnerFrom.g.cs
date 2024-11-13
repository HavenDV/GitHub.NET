
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryTransferredChangesOwnerFrom
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::GitHub.WebhookRepositoryTransferredChangesOwnerFromOrganization? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::GitHub.WebhookRepositoryTransferredChangesOwnerFromUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryTransferredChangesOwnerFrom" /> class.
        /// </summary>
        /// <param name="organization"></param>
        /// <param name="user"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookRepositoryTransferredChangesOwnerFrom(
            global::GitHub.WebhookRepositoryTransferredChangesOwnerFromOrganization? organization,
            global::GitHub.WebhookRepositoryTransferredChangesOwnerFromUser? user)
        {
            this.Organization = organization;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryTransferredChangesOwnerFrom" /> class.
        /// </summary>
        public WebhookRepositoryTransferredChangesOwnerFrom()
        {
        }
    }
}