#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get limits on GitHub-hosted runners for an organization<br/>
        /// Get the GitHub-hosted runners limits for an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ActionsHostedRunnerLimits> ActionsGetHostedRunnersLimitsForOrgAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}