#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Delete a GitHub-hosted runner for an organization<br/>
        /// Deletes a GitHub-hosted runner for an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hostedRunnerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ActionsHostedRunner> ActionsDeleteHostedRunnerForOrgAsync(
            string org,
            int hostedRunnerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}