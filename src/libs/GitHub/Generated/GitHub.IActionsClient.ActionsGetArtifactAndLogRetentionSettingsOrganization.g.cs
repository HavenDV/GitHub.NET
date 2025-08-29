#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get artifact and log retention settings for an organization<br/>
        /// Gets artifact and log retention settings for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope or the "Actions policies" fine-grained permission to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ActionsArtifactAndLogRetentionResponse> ActionsGetArtifactAndLogRetentionSettingsOrganizationAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}