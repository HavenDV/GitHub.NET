#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set GitHub Actions permissions for an organization<br/>
        /// Sets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetGithubActionsPermissionsOrganizationAsync(
            string org,
            global::GitHub.ActionsSetGithubActionsPermissionsOrganizationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set GitHub Actions permissions for an organization<br/>
        /// Sets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="enabledRepositories">
        /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions.
        /// </param>
        /// <param name="allowedActions">
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetGithubActionsPermissionsOrganizationAsync(
            string org,
            global::GitHub.EnabledRepositories enabledRepositories,
            global::GitHub.AllowedActions? allowedActions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}