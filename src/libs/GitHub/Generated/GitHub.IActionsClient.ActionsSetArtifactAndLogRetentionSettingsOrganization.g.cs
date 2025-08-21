#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set artifact and log retention settings for an organization<br/>
        /// Sets artifact and log retention settings for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope or the "Actions policies" fine-grained permission to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetArtifactAndLogRetentionSettingsOrganizationAsync(
            string org,
            global::GitHub.ActionsArtifactAndLogRetention request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set artifact and log retention settings for an organization<br/>
        /// Sets artifact and log retention settings for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope or the "Actions policies" fine-grained permission to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="days">
        /// The number of days to retain artifacts and logs
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetArtifactAndLogRetentionSettingsOrganizationAsync(
            string org,
            int days,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}