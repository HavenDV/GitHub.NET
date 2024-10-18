#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update an organization membership for the authenticated user<br/>
        /// Converts the authenticated user to an active member of the organization, if that user has a pending invitation from the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.OrgMembership> OrgsUpdateMembershipForAuthenticatedUserAsync(
            string org,
            global::GitHub.OrgsUpdateMembershipForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an organization membership for the authenticated user<br/>
        /// Converts the authenticated user to an active member of the organization, if that user has a pending invitation from the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="state">
        /// The state that the membership should be in. Only `"active"` will be accepted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.OrgMembership> OrgsUpdateMembershipForAuthenticatedUserAsync(
            string org,
            global::GitHub.OrgsUpdateMembershipForAuthenticatedUserRequestState state = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}