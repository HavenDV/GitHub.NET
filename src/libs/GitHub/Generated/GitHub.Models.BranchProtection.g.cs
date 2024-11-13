
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Branch Protection
    /// </summary>
    public sealed partial class BranchProtection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Protected Branch Required Status Check
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_status_checks")]
        public global::GitHub.ProtectedBranchRequiredStatusCheck? RequiredStatusChecks { get; set; }

        /// <summary>
        /// Protected Branch Admin Enforced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_admins")]
        public global::GitHub.ProtectedBranchAdminEnforced? EnforceAdmins { get; set; }

        /// <summary>
        /// Protected Branch Pull Request Review
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_pull_request_reviews")]
        public global::GitHub.ProtectedBranchPullRequestReview? RequiredPullRequestReviews { get; set; }

        /// <summary>
        /// Branch Restriction Policy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrictions")]
        public global::GitHub.BranchRestrictionPolicy? Restrictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_linear_history")]
        public global::GitHub.BranchProtectionRequiredLinearHistory? RequiredLinearHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_force_pushes")]
        public global::GitHub.BranchProtectionAllowForcePushes? AllowForcePushes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_deletions")]
        public global::GitHub.BranchProtectionAllowDeletions? AllowDeletions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_creations")]
        public global::GitHub.BranchProtectionBlockCreations? BlockCreations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_conversation_resolution")]
        public global::GitHub.BranchProtectionRequiredConversationResolution? RequiredConversationResolution { get; set; }

        /// <summary>
        /// Example: "branch/with/protection"
        /// </summary>
        /// <example>"branch/with/protection"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/repos/owner-79e94e2d36b3fd06a32bb213/AAA_Public_Repo/branches/branch/with/protection/protection"
        /// </summary>
        /// <example>"https://api.github.com/repos/owner-79e94e2d36b3fd06a32bb213/AAA_Public_Repo/branches/branch/with/protection/protection"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("protection_url")]
        public string? ProtectionUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_signatures")]
        public global::GitHub.BranchProtectionRequiredSignatures? RequiredSignatures { get; set; }

        /// <summary>
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_branch")]
        public global::GitHub.BranchProtectionLockBranch? LockBranch { get; set; }

        /// <summary>
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_fork_syncing")]
        public global::GitHub.BranchProtectionAllowForkSyncing? AllowForkSyncing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchProtection" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="enabled"></param>
        /// <param name="requiredStatusChecks">
        /// Protected Branch Required Status Check
        /// </param>
        /// <param name="enforceAdmins">
        /// Protected Branch Admin Enforced
        /// </param>
        /// <param name="requiredPullRequestReviews">
        /// Protected Branch Pull Request Review
        /// </param>
        /// <param name="restrictions">
        /// Branch Restriction Policy
        /// </param>
        /// <param name="requiredLinearHistory"></param>
        /// <param name="allowForcePushes"></param>
        /// <param name="allowDeletions"></param>
        /// <param name="blockCreations"></param>
        /// <param name="requiredConversationResolution"></param>
        /// <param name="name">
        /// Example: "branch/with/protection"
        /// </param>
        /// <param name="protectionUrl">
        /// Example: "https://api.github.com/repos/owner-79e94e2d36b3fd06a32bb213/AAA_Public_Repo/branches/branch/with/protection/protection"
        /// </param>
        /// <param name="requiredSignatures"></param>
        /// <param name="lockBranch">
        /// Whether to set the branch as read-only. If this is true, users will not be able to push to the branch.
        /// </param>
        /// <param name="allowForkSyncing">
        /// Whether users can pull changes from upstream when the branch is locked. Set to `true` to allow fork syncing. Set to `false` to prevent fork syncing.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BranchProtection(
            string? url,
            bool? enabled,
            global::GitHub.ProtectedBranchRequiredStatusCheck? requiredStatusChecks,
            global::GitHub.ProtectedBranchAdminEnforced? enforceAdmins,
            global::GitHub.ProtectedBranchPullRequestReview? requiredPullRequestReviews,
            global::GitHub.BranchRestrictionPolicy? restrictions,
            global::GitHub.BranchProtectionRequiredLinearHistory? requiredLinearHistory,
            global::GitHub.BranchProtectionAllowForcePushes? allowForcePushes,
            global::GitHub.BranchProtectionAllowDeletions? allowDeletions,
            global::GitHub.BranchProtectionBlockCreations? blockCreations,
            global::GitHub.BranchProtectionRequiredConversationResolution? requiredConversationResolution,
            string? name,
            string? protectionUrl,
            global::GitHub.BranchProtectionRequiredSignatures? requiredSignatures,
            global::GitHub.BranchProtectionLockBranch? lockBranch,
            global::GitHub.BranchProtectionAllowForkSyncing? allowForkSyncing)
        {
            this.Url = url;
            this.Enabled = enabled;
            this.RequiredStatusChecks = requiredStatusChecks;
            this.EnforceAdmins = enforceAdmins;
            this.RequiredPullRequestReviews = requiredPullRequestReviews;
            this.Restrictions = restrictions;
            this.RequiredLinearHistory = requiredLinearHistory;
            this.AllowForcePushes = allowForcePushes;
            this.AllowDeletions = allowDeletions;
            this.BlockCreations = blockCreations;
            this.RequiredConversationResolution = requiredConversationResolution;
            this.Name = name;
            this.ProtectionUrl = protectionUrl;
            this.RequiredSignatures = requiredSignatures;
            this.LockBranch = lockBranch;
            this.AllowForkSyncing = allowForkSyncing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchProtection" /> class.
        /// </summary>
        public BranchProtection()
        {
        }
    }
}