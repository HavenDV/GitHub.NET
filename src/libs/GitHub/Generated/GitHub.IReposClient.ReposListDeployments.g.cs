#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List deployments<br/>
        /// Simple filtering of deployments is available via query parameters:
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sha">
        /// Default Value: none
        /// </param>
        /// <param name="ref">
        /// Default Value: none
        /// </param>
        /// <param name="task">
        /// Default Value: none
        /// </param>
        /// <param name="environment">
        /// Default Value: none
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Deployment>> ReposListDeploymentsAsync(
            string owner,
            string repo,
            string? sha = "none",
            string? @ref = "none",
            string? task = "none",
            string? environment = "none",
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}