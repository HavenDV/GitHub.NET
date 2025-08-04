#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set private repo fork PR workflow settings for an organization<br/>
        /// Sets the settings for whether workflows from fork pull requests can run on private repositories in an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetPrivateRepoForkPrWorkflowsSettingsOrganizationAsync(
            string org,
            global::GitHub.ActionsForkPrWorkflowsPrivateReposRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set private repo fork PR workflow settings for an organization<br/>
        /// Sets the settings for whether workflows from fork pull requests can run on private repositories in an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runWorkflowsFromForkPullRequests">
        /// Whether workflows triggered by pull requests from forks are allowed to run on private repositories.
        /// </param>
        /// <param name="sendWriteTokensToWorkflows">
        /// Whether GitHub Actions can create pull requests or submit approving pull request reviews from a workflow triggered by a fork pull request.
        /// </param>
        /// <param name="sendSecretsAndVariables">
        /// Whether to make secrets and variables available to workflows triggered by pull requests from forks.
        /// </param>
        /// <param name="requireApprovalForForkPrWorkflows">
        /// Whether workflows triggered by pull requests from forks require approval from a repository administrator to run.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetPrivateRepoForkPrWorkflowsSettingsOrganizationAsync(
            string org,
            bool runWorkflowsFromForkPullRequests,
            bool? sendWriteTokensToWorkflows = default,
            bool? sendSecretsAndVariables = default,
            bool? requireApprovalForForkPrWorkflows = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}