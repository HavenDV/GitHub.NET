#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Disable a custom protection rule for an environment<br/>
        /// Disables a custom deployment protection rule for an environment.<br/>
        /// The authenticated user must have admin or owner permissions to the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="environmentName"></param>
        /// <param name="repo"></param>
        /// <param name="owner"></param>
        /// <param name="protectionRuleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReposDisableDeploymentProtectionRuleAsync(
            string environmentName,
            string repo,
            string owner,
            int protectionRuleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}