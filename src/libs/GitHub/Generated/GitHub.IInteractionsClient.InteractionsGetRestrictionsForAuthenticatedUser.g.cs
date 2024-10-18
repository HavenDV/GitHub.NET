#nullable enable

namespace GitHub
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Get interaction restrictions for your public repositories<br/>
        /// Shows which type of GitHub user can interact with your public repositories and when the restriction expires.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.AnyOf<global::GitHub.InteractionLimitResponse, global::GitHub.InteractionsGetRestrictionsForAuthenticatedUserResponse2>> InteractionsGetRestrictionsForAuthenticatedUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}