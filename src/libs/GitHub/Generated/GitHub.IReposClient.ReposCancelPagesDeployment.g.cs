#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Cancel a GitHub Pages deployment<br/>
        /// Cancels a GitHub Pages deployment.<br/>
        /// The authenticated user must have write permissions for the GitHub Pages site.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pagesDeploymentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BasicError> ReposCancelPagesDeploymentAsync(
            string owner,
            string repo,
            global::GitHub.OneOf<int?, string> pagesDeploymentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}