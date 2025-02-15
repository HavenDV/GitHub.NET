#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get an organization membership for the authenticated user<br/>
        /// If the authenticated user is an active or pending member of the organization, this endpoint will return the user's membership. If the authenticated user is not affiliated with the organization, a `404` is returned. This endpoint will return a `403` if the request is made by a GitHub App that is blocked by the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.OrgMembership> OrgsGetMembershipForAuthenticatedUserAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}