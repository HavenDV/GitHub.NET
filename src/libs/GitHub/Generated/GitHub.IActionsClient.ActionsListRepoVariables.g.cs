#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// List repository variables<br/>
        /// Lists all repository variables.<br/>
        /// Authenticated users must have collaborator access to a repository to create, update, or read variables.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ActionsListRepoVariablesResponse> ActionsListRepoVariablesAsync(
            string owner,
            string repo,
            int? perPage = 10,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}