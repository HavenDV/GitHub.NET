#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get platforms for GitHub-hosted runners in an organization<br/>
        /// Get the list of platforms available for GitHub-hosted runners for an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ActionsGetHostedRunnersPlatformsForOrgResponse> ActionsGetHostedRunnersPlatformsForOrgAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}