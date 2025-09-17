
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleCopilotCodeReviewParameters
    {
        /// <summary>
        /// Copilot automatically reviews draft pull requests before they are marked as ready for review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_draft_pull_requests")]
        public bool? ReviewDraftPullRequests { get; set; }

        /// <summary>
        /// Copilot automatically reviews each new push to the pull request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_on_push")]
        public bool? ReviewOnPush { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCopilotCodeReviewParameters" /> class.
        /// </summary>
        /// <param name="reviewDraftPullRequests">
        /// Copilot automatically reviews draft pull requests before they are marked as ready for review.
        /// </param>
        /// <param name="reviewOnPush">
        /// Copilot automatically reviews each new push to the pull request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleCopilotCodeReviewParameters(
            bool? reviewDraftPullRequests,
            bool? reviewOnPush)
        {
            this.ReviewDraftPullRequests = reviewDraftPullRequests;
            this.ReviewOnPush = reviewOnPush;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCopilotCodeReviewParameters" /> class.
        /// </summary>
        public RepositoryRuleCopilotCodeReviewParameters()
        {
        }
    }
}