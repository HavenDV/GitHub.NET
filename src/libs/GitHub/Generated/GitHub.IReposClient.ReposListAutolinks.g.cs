#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get all autolinks of a repository<br/>
        /// Gets all autolinks that are configured for a repository.<br/>
        /// Information about autolinks are only available to repository administrators.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Autolink>> ReposListAutolinksAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}