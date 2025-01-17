#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get a GitHub-hosted runner for an organization<br/>
        /// Gets a GitHub-hosted runner configured in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `manage_runners:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hostedRunnerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ActionsHostedRunner> ActionsGetHostedRunnerForOrgAsync(
            string org,
            int hostedRunnerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}