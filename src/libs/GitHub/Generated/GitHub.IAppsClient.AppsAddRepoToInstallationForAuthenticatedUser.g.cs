#nullable enable

namespace GitHub
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Add a repository to an app installation<br/>
        /// Add a single repository to an installation. The authenticated user must have admin access to the repository.    <br/>
        /// This endpoint only works for PATs (classic) with the `repo` scope.
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="repositoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BasicError> AppsAddRepoToInstallationForAuthenticatedUserAsync(
            int installationId,
            int repositoryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}