#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set repositories allowed to use self-hosted runners in an organization<br/>
        /// Sets repositories that are allowed to use self-hosted runners in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope or the "Actions policies" fine-grained permission to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetSelectedRepositoriesSelfHostedRunnersOrganizationAsync(
            string org,
            global::GitHub.ActionsSetSelectedRepositoriesSelfHostedRunnersOrganizationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set repositories allowed to use self-hosted runners in an organization<br/>
        /// Sets repositories that are allowed to use self-hosted runners in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope or the "Actions policies" fine-grained permission to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="selectedRepositoryIds">
        /// IDs of repositories that can use repository-level self-hosted runners
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetSelectedRepositoriesSelfHostedRunnersOrganizationAsync(
            string org,
            global::System.Collections.Generic.IList<int> selectedRepositoryIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}