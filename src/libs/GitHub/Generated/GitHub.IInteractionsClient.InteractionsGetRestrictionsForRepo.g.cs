#nullable enable

namespace GitHub
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Get interaction restrictions for a repository<br/>
        /// Shows which type of GitHub user can interact with this repository and when the restriction expires. If there are no restrictions, you will see an empty response.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.AnyOf<global::GitHub.InteractionLimitResponse, global::GitHub.InteractionsGetRestrictionsForRepoResponse2>> InteractionsGetRestrictionsForRepoAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}