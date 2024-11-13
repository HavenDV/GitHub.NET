
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Information about repositories that were skipped from processing. This information is only available to the user that initiated the variant analysis.
    /// </summary>
    public sealed partial class CodeScanningVariantAnalysisSkippedRepositories
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_mismatch_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeScanningVariantAnalysisSkippedRepoGroup AccessMismatchRepos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not_found_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeScanningVariantAnalysisSkippedRepositoriesNotFoundRepos NotFoundRepos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_codeql_db_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeScanningVariantAnalysisSkippedRepoGroup NoCodeqlDbRepos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("over_limit_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeScanningVariantAnalysisSkippedRepoGroup OverLimitRepos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysisSkippedRepositories" /> class.
        /// </summary>
        /// <param name="accessMismatchRepos"></param>
        /// <param name="notFoundRepos"></param>
        /// <param name="noCodeqlDbRepos"></param>
        /// <param name="overLimitRepos"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodeScanningVariantAnalysisSkippedRepositories(
            global::GitHub.CodeScanningVariantAnalysisSkippedRepoGroup accessMismatchRepos,
            global::GitHub.CodeScanningVariantAnalysisSkippedRepositoriesNotFoundRepos notFoundRepos,
            global::GitHub.CodeScanningVariantAnalysisSkippedRepoGroup noCodeqlDbRepos,
            global::GitHub.CodeScanningVariantAnalysisSkippedRepoGroup overLimitRepos)
        {
            this.AccessMismatchRepos = accessMismatchRepos ?? throw new global::System.ArgumentNullException(nameof(accessMismatchRepos));
            this.NotFoundRepos = notFoundRepos ?? throw new global::System.ArgumentNullException(nameof(notFoundRepos));
            this.NoCodeqlDbRepos = noCodeqlDbRepos ?? throw new global::System.ArgumentNullException(nameof(noCodeqlDbRepos));
            this.OverLimitRepos = overLimitRepos ?? throw new global::System.ArgumentNullException(nameof(overLimitRepos));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningVariantAnalysisSkippedRepositories" /> class.
        /// </summary>
        public CodeScanningVariantAnalysisSkippedRepositories()
        {
        }
    }
}