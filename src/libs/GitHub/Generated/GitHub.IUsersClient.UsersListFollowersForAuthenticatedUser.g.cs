#nullable enable

namespace GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List followers of the authenticated user<br/>
        /// Lists the people following the authenticated user.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.SimpleUser>> UsersListFollowersForAuthenticatedUserAsync(
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}