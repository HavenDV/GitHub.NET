#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get a deployment status<br/>
        /// Users with pull access can view a deployment status for a deployment:
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="deploymentId"></param>
        /// <param name="statusId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.DeploymentStatus> ReposGetDeploymentStatusAsync(
            string owner,
            string repo,
            int deploymentId,
            int statusId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}