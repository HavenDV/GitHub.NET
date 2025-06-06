
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The status of auto merging a pull request.
    /// </summary>
    public sealed partial class WebhookPullRequestSynchronizePullRequestAutoMerge
    {
        /// <summary>
        /// Commit message for the merge commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? CommitMessage { get; set; }

        /// <summary>
        /// Title for the merge commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? CommitTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestSynchronizePullRequestAutoMergeEnabledBy? EnabledBy { get; set; }

        /// <summary>
        /// The merge method to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookPullRequestSynchronizePullRequestAutoMergeMergeMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookPullRequestSynchronizePullRequestAutoMergeMergeMethod MergeMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestSynchronizePullRequestAutoMerge" /> class.
        /// </summary>
        /// <param name="commitMessage">
        /// Commit message for the merge commit.
        /// </param>
        /// <param name="commitTitle">
        /// Title for the merge commit message.
        /// </param>
        /// <param name="enabledBy"></param>
        /// <param name="mergeMethod">
        /// The merge method to use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPullRequestSynchronizePullRequestAutoMerge(
            string? commitMessage,
            string? commitTitle,
            global::GitHub.WebhookPullRequestSynchronizePullRequestAutoMergeEnabledBy? enabledBy,
            global::GitHub.WebhookPullRequestSynchronizePullRequestAutoMergeMergeMethod mergeMethod)
        {
            this.CommitMessage = commitMessage ?? throw new global::System.ArgumentNullException(nameof(commitMessage));
            this.CommitTitle = commitTitle ?? throw new global::System.ArgumentNullException(nameof(commitTitle));
            this.EnabledBy = enabledBy ?? throw new global::System.ArgumentNullException(nameof(enabledBy));
            this.MergeMethod = mergeMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestSynchronizePullRequestAutoMerge" /> class.
        /// </summary>
        public WebhookPullRequestSynchronizePullRequestAutoMerge()
        {
        }
    }
}