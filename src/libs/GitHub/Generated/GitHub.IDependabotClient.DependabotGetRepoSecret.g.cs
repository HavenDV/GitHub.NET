#nullable enable

namespace GitHub
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// Get a repository secret<br/>
        /// Gets a single repository secret without revealing its encrypted value.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="secretName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.DependabotSecret> DependabotGetRepoSecretAsync(
            string owner,
            string repo,
            string secretName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}