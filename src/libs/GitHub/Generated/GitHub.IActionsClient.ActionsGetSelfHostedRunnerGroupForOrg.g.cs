#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get a self-hosted runner group for an organization<br/>
        /// Gets a specific self-hosted runner group for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.RunnerGroupsOrg> ActionsGetSelfHostedRunnerGroupForOrgAsync(
            string org,
            int runnerGroupId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}