
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_branch")]
        public global::GitHub.WebhookRepositoryEditedChangesDefaultBranch? DefaultBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::GitHub.WebhookRepositoryEditedChangesDescription? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("homepage")]
        public global::GitHub.WebhookRepositoryEditedChangesHomepage? Homepage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::GitHub.WebhookRepositoryEditedChangesTopics? Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryEditedChanges" /> class.
        /// </summary>
        /// <param name="defaultBranch"></param>
        /// <param name="description"></param>
        /// <param name="homepage"></param>
        /// <param name="topics"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookRepositoryEditedChanges(
            global::GitHub.WebhookRepositoryEditedChangesDefaultBranch? defaultBranch,
            global::GitHub.WebhookRepositoryEditedChangesDescription? description,
            global::GitHub.WebhookRepositoryEditedChangesHomepage? homepage,
            global::GitHub.WebhookRepositoryEditedChangesTopics? topics)
        {
            this.DefaultBranch = defaultBranch;
            this.Description = description;
            this.Homepage = homepage;
            this.Topics = topics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryEditedChanges" /> class.
        /// </summary>
        public WebhookRepositoryEditedChanges()
        {
        }
    }
}