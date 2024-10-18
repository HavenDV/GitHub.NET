#nullable enable

namespace GitHub
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Get interaction restrictions for an organization<br/>
        /// Shows which type of GitHub user can interact with this organization and when the restriction expires. If there is no restrictions, you will see an empty response.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.AnyOf<global::GitHub.InteractionLimitResponse, global::GitHub.InteractionsGetRestrictionsForOrgResponse2>> InteractionsGetRestrictionsForOrgAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}