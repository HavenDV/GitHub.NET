#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List organization memberships for the authenticated user<br/>
        /// Lists all of the authenticated user's organization memberships.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.OrgMembership>> OrgsListMembershipsForAuthenticatedUserAsync(
            global::GitHub.OrgsListMembershipsForAuthenticatedUserState? state = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}