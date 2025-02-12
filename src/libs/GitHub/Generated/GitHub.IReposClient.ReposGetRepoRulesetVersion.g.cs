#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get repository ruleset version<br/>
        /// Get a version of a repository ruleset.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="rulesetId"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.RulesetVersionWithState> ReposGetRepoRulesetVersionAsync(
            string owner,
            string repo,
            int rulesetId,
            int versionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}