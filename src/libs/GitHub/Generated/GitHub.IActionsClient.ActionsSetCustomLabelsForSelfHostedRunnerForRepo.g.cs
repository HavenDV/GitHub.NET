#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set custom labels for a self-hosted runner for a repository<br/>
        /// Remove all previous custom labels and set the new custom labels for a specific<br/>
        /// self-hosted runner configured in a repository.<br/>
        /// Authenticated users must have admin access to the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ActionsSetCustomLabelsForSelfHostedRunnerForRepoResponse> ActionsSetCustomLabelsForSelfHostedRunnerForRepoAsync(
            string owner,
            string repo,
            int runnerId,
            global::GitHub.ActionsSetCustomLabelsForSelfHostedRunnerForRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set custom labels for a self-hosted runner for a repository<br/>
        /// Remove all previous custom labels and set the new custom labels for a specific<br/>
        /// self-hosted runner configured in a repository.<br/>
        /// Authenticated users must have admin access to the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runnerId"></param>
        /// <param name="labels">
        /// The names of the custom labels to set for the runner. You can pass an empty array to remove all custom labels.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ActionsSetCustomLabelsForSelfHostedRunnerForRepoResponse> ActionsSetCustomLabelsForSelfHostedRunnerForRepoAsync(
            string owner,
            string repo,
            int runnerId,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}