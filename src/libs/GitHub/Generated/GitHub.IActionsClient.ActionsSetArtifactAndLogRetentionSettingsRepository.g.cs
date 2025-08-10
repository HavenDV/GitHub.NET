#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set artifact and log retention settings for a repository<br/>
        /// Sets artifact and log retention settings for a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetArtifactAndLogRetentionSettingsRepositoryAsync(
            string owner,
            string repo,
            global::GitHub.ActionsArtifactAndLogRetention request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set artifact and log retention settings for a repository<br/>
        /// Sets artifact and log retention settings for a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="days">
        /// The number of days to retain artifacts and logs
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetArtifactAndLogRetentionSettingsRepositoryAsync(
            string owner,
            string repo,
            int days,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}