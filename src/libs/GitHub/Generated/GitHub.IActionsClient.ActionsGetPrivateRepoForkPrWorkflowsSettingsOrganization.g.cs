#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get private repo fork PR workflow settings for an organization<br/>
        /// Gets the settings for whether workflows from fork pull requests can run on private repositories in an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ActionsForkPrWorkflowsPrivateRepos> ActionsGetPrivateRepoForkPrWorkflowsSettingsOrganizationAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}