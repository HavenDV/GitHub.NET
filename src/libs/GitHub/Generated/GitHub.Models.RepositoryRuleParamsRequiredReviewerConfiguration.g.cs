
#nullable enable

namespace GitHub
{
    /// <summary>
    /// A reviewing team, and file patterns describing which files they must approve changes to.
    /// </summary>
    public sealed partial class RepositoryRuleParamsRequiredReviewerConfiguration
    {
        /// <summary>
        /// Array of file patterns. Pull requests which change matching files must be approved by the specified team. File patterns use the same syntax as `.gitignore` files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_patterns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FilePatterns { get; set; }

        /// <summary>
        /// Minimum number of approvals required from the specified team. If set to zero, the team will be added to the pull request but approval is optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_approvals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinimumApprovals { get; set; }

        /// <summary>
        /// Node ID of the team which must review changes to matching files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReviewerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsRequiredReviewerConfiguration" /> class.
        /// </summary>
        /// <param name="filePatterns">
        /// Array of file patterns. Pull requests which change matching files must be approved by the specified team. File patterns use the same syntax as `.gitignore` files.
        /// </param>
        /// <param name="minimumApprovals">
        /// Minimum number of approvals required from the specified team. If set to zero, the team will be added to the pull request but approval is optional.
        /// </param>
        /// <param name="reviewerId">
        /// Node ID of the team which must review changes to matching files.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleParamsRequiredReviewerConfiguration(
            global::System.Collections.Generic.IList<string> filePatterns,
            int minimumApprovals,
            string reviewerId)
        {
            this.FilePatterns = filePatterns ?? throw new global::System.ArgumentNullException(nameof(filePatterns));
            this.MinimumApprovals = minimumApprovals;
            this.ReviewerId = reviewerId ?? throw new global::System.ArgumentNullException(nameof(reviewerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsRequiredReviewerConfiguration" /> class.
        /// </summary>
        public RepositoryRuleParamsRequiredReviewerConfiguration()
        {
        }
    }
}