
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPullRequestReviewThreadUnresolvedThreadCommentLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestReviewThreadUnresolvedThreadCommentLinksHtml Html { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestReviewThreadUnresolvedThreadCommentLinksPullRequest PullRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestReviewThreadUnresolvedThreadCommentLinksSelf Self { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}