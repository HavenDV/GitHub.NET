#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// List GitHub Actions caches for a repository<br/>
        /// Lists the GitHub Actions caches for a repository.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="ref"></param>
        /// <param name="key"></param>
        /// <param name="sort">
        /// Default Value: last_accessed_at
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ActionsCacheList> ActionsGetActionsCacheListAsync(
            string owner,
            string repo,
            int? perPage = 30,
            int? page = 1,
            string? @ref = default,
            string? key = default,
            global::GitHub.ActionsGetActionsCacheListSort? sort = global::GitHub.ActionsGetActionsCacheListSort.LastAccessedAt,
            global::GitHub.ActionsGetActionsCacheListDirection? direction = global::GitHub.ActionsGetActionsCacheListDirection.Desc,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}