#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get GitHub Pages build<br/>
        /// Gets information about a GitHub Pages build.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="buildId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.PageBuild> ReposGetPagesBuildAsync(
            string owner,
            string repo,
            int buildId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}