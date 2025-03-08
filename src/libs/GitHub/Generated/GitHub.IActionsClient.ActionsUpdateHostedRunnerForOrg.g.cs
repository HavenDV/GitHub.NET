#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Update a GitHub-hosted runner for an organization<br/>
        /// Updates a GitHub-hosted runner for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `manage_runners:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hostedRunnerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ActionsHostedRunner> ActionsUpdateHostedRunnerForOrgAsync(
            string org,
            int hostedRunnerId,
            global::GitHub.ActionsUpdateHostedRunnerForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a GitHub-hosted runner for an organization<br/>
        /// Updates a GitHub-hosted runner for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `manage_runners:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hostedRunnerId"></param>
        /// <param name="name">
        /// Name of the runner. Must be between 1 and 64 characters and may only contain upper and lowercase letters a-z, numbers 0-9, '.', '-', and '_'.
        /// </param>
        /// <param name="runnerGroupId">
        /// The existing runner group to add this runner to.
        /// </param>
        /// <param name="maximumRunners">
        /// The maximum amount of runners to scale up to. Runners will not auto-scale above this number. Use this setting to limit your cost.
        /// </param>
        /// <param name="enableStaticIp">
        /// Whether this runner should be updated with a static public IP. Note limit on account. To list limits on account, use `GET actions/hosted-runners/limits`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ActionsHostedRunner> ActionsUpdateHostedRunnerForOrgAsync(
            string org,
            int hostedRunnerId,
            string? name = default,
            int? runnerGroupId = default,
            int? maximumRunners = default,
            bool? enableStaticIp = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}