#nullable enable

namespace GitHub
{
    public partial interface IMigrationsClient
    {
        /// <summary>
        /// List repositories for a user migration<br/>
        /// Lists all the repositories for this user migration.
        /// </summary>
        /// <param name="migrationId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.MinimalRepository>> MigrationsListReposForAuthenticatedUserAsync(
            int migrationId,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}