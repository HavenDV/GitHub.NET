#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Delete a repository ruleset<br/>
        /// Delete a ruleset for a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="rulesetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ReposDeleteRepoRulesetAsync(
            string owner,
            string repo,
            int rulesetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}