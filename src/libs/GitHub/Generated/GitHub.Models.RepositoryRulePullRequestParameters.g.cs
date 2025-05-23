
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRulePullRequestParameters
    {
        /// <summary>
        /// Array of allowed merge methods. Allowed values include `merge`, `squash`, and `rebase`. At least one option must be enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_merge_methods")]
        public global::System.Collections.Generic.IList<global::GitHub.RepositoryRulePullRequestParametersAllowedMergeMethod>? AllowedMergeMethods { get; set; }

        /// <summary>
        /// Automatically request review from Copilot for new pull requests, if the author has access to Copilot code review.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automatic_copilot_code_review_enabled")]
        public bool? AutomaticCopilotCodeReviewEnabled { get; set; }

        /// <summary>
        /// New, reviewable commits pushed will dismiss previous pull request review approvals.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismiss_stale_reviews_on_push")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DismissStaleReviewsOnPush { get; set; }

        /// <summary>
        /// Require an approving review in pull requests that modify files that have a designated code owner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_code_owner_review")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequireCodeOwnerReview { get; set; }

        /// <summary>
        /// Whether the most recent reviewable push must be approved by someone other than the person who pushed it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_last_push_approval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequireLastPushApproval { get; set; }

        /// <summary>
        /// The number of approving reviews that are required before a pull request can be merged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_approving_review_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequiredApprovingReviewCount { get; set; }

        /// <summary>
        /// All conversations on code must be resolved before a pull request can be merged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_review_thread_resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequiredReviewThreadResolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulePullRequestParameters" /> class.
        /// </summary>
        /// <param name="allowedMergeMethods">
        /// Array of allowed merge methods. Allowed values include `merge`, `squash`, and `rebase`. At least one option must be enabled.
        /// </param>
        /// <param name="automaticCopilotCodeReviewEnabled">
        /// Automatically request review from Copilot for new pull requests, if the author has access to Copilot code review.
        /// </param>
        /// <param name="dismissStaleReviewsOnPush">
        /// New, reviewable commits pushed will dismiss previous pull request review approvals.
        /// </param>
        /// <param name="requireCodeOwnerReview">
        /// Require an approving review in pull requests that modify files that have a designated code owner.
        /// </param>
        /// <param name="requireLastPushApproval">
        /// Whether the most recent reviewable push must be approved by someone other than the person who pushed it.
        /// </param>
        /// <param name="requiredApprovingReviewCount">
        /// The number of approving reviews that are required before a pull request can be merged.
        /// </param>
        /// <param name="requiredReviewThreadResolution">
        /// All conversations on code must be resolved before a pull request can be merged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRulePullRequestParameters(
            bool dismissStaleReviewsOnPush,
            bool requireCodeOwnerReview,
            bool requireLastPushApproval,
            int requiredApprovingReviewCount,
            bool requiredReviewThreadResolution,
            global::System.Collections.Generic.IList<global::GitHub.RepositoryRulePullRequestParametersAllowedMergeMethod>? allowedMergeMethods,
            bool? automaticCopilotCodeReviewEnabled)
        {
            this.DismissStaleReviewsOnPush = dismissStaleReviewsOnPush;
            this.RequireCodeOwnerReview = requireCodeOwnerReview;
            this.RequireLastPushApproval = requireLastPushApproval;
            this.RequiredApprovingReviewCount = requiredApprovingReviewCount;
            this.RequiredReviewThreadResolution = requiredReviewThreadResolution;
            this.AllowedMergeMethods = allowedMergeMethods;
            this.AutomaticCopilotCodeReviewEnabled = automaticCopilotCodeReviewEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulePullRequestParameters" /> class.
        /// </summary>
        public RepositoryRulePullRequestParameters()
        {
        }
    }
}