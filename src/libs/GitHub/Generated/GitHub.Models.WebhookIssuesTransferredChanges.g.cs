
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookIssuesTransferredChanges
    {
        /// <summary>
        /// The [issue](https://docs.github.com/rest/issues/issues#get-an-issue) itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_issue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookIssuesTransferredChangesNewIssue NewIssue { get; set; }

        /// <summary>
        /// A git repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookIssuesTransferredChangesNewRepository NewRepository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesTransferredChanges" /> class.
        /// </summary>
        /// <param name="newIssue">
        /// The [issue](https://docs.github.com/rest/issues/issues#get-an-issue) itself.
        /// </param>
        /// <param name="newRepository">
        /// A git repository
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookIssuesTransferredChanges(
            global::GitHub.WebhookIssuesTransferredChangesNewIssue newIssue,
            global::GitHub.WebhookIssuesTransferredChangesNewRepository newRepository)
        {
            this.NewIssue = newIssue ?? throw new global::System.ArgumentNullException(nameof(newIssue));
            this.NewRepository = newRepository ?? throw new global::System.ArgumentNullException(nameof(newRepository));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesTransferredChanges" /> class.
        /// </summary>
        public WebhookIssuesTransferredChanges()
        {
        }
    }
}