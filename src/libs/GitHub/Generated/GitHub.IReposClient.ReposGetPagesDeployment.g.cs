#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get the status of a GitHub Pages deployment<br/>
        /// Gets the current status of a GitHub Pages deployment.<br/>
        /// The authenticated user must have read permission for the GitHub Pages site.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pagesDeploymentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.PagesDeploymentStatus> ReposGetPagesDeploymentAsync(
            string owner,
            string repo,
            global::GitHub.OneOf<int?, string> pagesDeploymentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}