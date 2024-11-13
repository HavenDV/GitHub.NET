#nullable enable

namespace GitHub
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// GitHub API Root<br/>
        /// Get Hypermedia links to resources accessible in GitHub's REST API
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Root> MetaRootAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}