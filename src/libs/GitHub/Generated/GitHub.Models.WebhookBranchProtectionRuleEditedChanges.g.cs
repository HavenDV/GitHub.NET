
#nullable enable

namespace GitHub
{
    /// <summary>
    /// If the action was `edited`, the changes to the rule.
    /// </summary>
    public sealed partial class WebhookBranchProtectionRuleEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admin_enforced")]
        public global::GitHub.WebhookBranchProtectionRuleEditedChangesAdminEnforced? AdminEnforced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorized_actor_names")]
        public global::GitHub.WebhookBranchProtectionRuleEditedChangesAuthorizedActorNames? AuthorizedActorNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorized_actors_only")]
        public global::GitHub.WebhookBranchProtectionRuleEditedChangesAuthorizedActorsOnly? AuthorizedActorsOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorized_dismissal_actors_only")]
        public global::GitHub.WebhookBranchProtectionRuleEditedChangesAuthorizedDismissalActorsOnly? AuthorizedDismissalActorsOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linear_history_requirement_enforcement_level")]
        public global::GitHub.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevel? LinearHistoryRequirementEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_branch_enforcement_level")]
        public global::GitHub.WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevel? LockBranchEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_allows_fork_sync")]
        public global::GitHub.WebhookBranchProtectionRuleEditedChangesLockAllowsForkSync? LockAllowsForkSync { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_reviews_enforcement_level")]
        public global::GitHub.WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevel? PullRequestReviewsEnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_last_push_approval")]
        public global::GitHub.WebhookBranchProtectionRuleEditedChangesRequireLastPushApproval? RequireLastPushApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_status_checks")]
        public global::GitHub.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecks? RequiredStatusChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_status_checks_enforcement_level")]
        public global::GitHub.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevel? RequiredStatusChecksEnforcementLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChanges" /> class.
        /// </summary>
        /// <param name="adminEnforced"></param>
        /// <param name="authorizedActorNames"></param>
        /// <param name="authorizedActorsOnly"></param>
        /// <param name="authorizedDismissalActorsOnly"></param>
        /// <param name="linearHistoryRequirementEnforcementLevel"></param>
        /// <param name="lockBranchEnforcementLevel"></param>
        /// <param name="lockAllowsForkSync"></param>
        /// <param name="pullRequestReviewsEnforcementLevel"></param>
        /// <param name="requireLastPushApproval"></param>
        /// <param name="requiredStatusChecks"></param>
        /// <param name="requiredStatusChecksEnforcementLevel"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookBranchProtectionRuleEditedChanges(
            global::GitHub.WebhookBranchProtectionRuleEditedChangesAdminEnforced? adminEnforced,
            global::GitHub.WebhookBranchProtectionRuleEditedChangesAuthorizedActorNames? authorizedActorNames,
            global::GitHub.WebhookBranchProtectionRuleEditedChangesAuthorizedActorsOnly? authorizedActorsOnly,
            global::GitHub.WebhookBranchProtectionRuleEditedChangesAuthorizedDismissalActorsOnly? authorizedDismissalActorsOnly,
            global::GitHub.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevel? linearHistoryRequirementEnforcementLevel,
            global::GitHub.WebhookBranchProtectionRuleEditedChangesLockBranchEnforcementLevel? lockBranchEnforcementLevel,
            global::GitHub.WebhookBranchProtectionRuleEditedChangesLockAllowsForkSync? lockAllowsForkSync,
            global::GitHub.WebhookBranchProtectionRuleEditedChangesPullRequestReviewsEnforcementLevel? pullRequestReviewsEnforcementLevel,
            global::GitHub.WebhookBranchProtectionRuleEditedChangesRequireLastPushApproval? requireLastPushApproval,
            global::GitHub.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecks? requiredStatusChecks,
            global::GitHub.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevel? requiredStatusChecksEnforcementLevel)
        {
            this.AdminEnforced = adminEnforced;
            this.AuthorizedActorNames = authorizedActorNames;
            this.AuthorizedActorsOnly = authorizedActorsOnly;
            this.AuthorizedDismissalActorsOnly = authorizedDismissalActorsOnly;
            this.LinearHistoryRequirementEnforcementLevel = linearHistoryRequirementEnforcementLevel;
            this.LockBranchEnforcementLevel = lockBranchEnforcementLevel;
            this.LockAllowsForkSync = lockAllowsForkSync;
            this.PullRequestReviewsEnforcementLevel = pullRequestReviewsEnforcementLevel;
            this.RequireLastPushApproval = requireLastPushApproval;
            this.RequiredStatusChecks = requiredStatusChecks;
            this.RequiredStatusChecksEnforcementLevel = requiredStatusChecksEnforcementLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChanges" /> class.
        /// </summary>
        public WebhookBranchProtectionRuleEditedChanges()
        {
        }
    }
}