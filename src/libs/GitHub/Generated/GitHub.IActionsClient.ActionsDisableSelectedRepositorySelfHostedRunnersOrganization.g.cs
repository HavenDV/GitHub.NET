#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Remove a repository from the list of repositories allowed to use self-hosted runners in an organization<br/>
        /// Removes a repository from the list of repositories that are allowed to use self-hosted runners in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope or the "Actions policies" fine-grained permission to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repositoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsDisableSelectedRepositorySelfHostedRunnersOrganizationAsync(
            string org,
            int repositoryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}