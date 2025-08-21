#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set self-hosted runners settings for an organization<br/>
        /// Sets the settings for self-hosted runners for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope or the "Actions policies" fine-grained permission to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetSelfHostedRunnersPermissionsOrganizationAsync(
            string org,
            global::GitHub.ActionsSetSelfHostedRunnersPermissionsOrganizationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set self-hosted runners settings for an organization<br/>
        /// Sets the settings for self-hosted runners for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope or the "Actions policies" fine-grained permission to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="enabledRepositories">
        /// The policy that controls whether self-hosted runners can be used in the organization
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetSelfHostedRunnersPermissionsOrganizationAsync(
            string org,
            global::GitHub.ActionsSetSelfHostedRunnersPermissionsOrganizationRequestEnabledRepositories enabledRepositories,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}