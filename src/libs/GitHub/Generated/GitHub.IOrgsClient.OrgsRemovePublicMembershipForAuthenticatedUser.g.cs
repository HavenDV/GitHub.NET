#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Remove public organization membership for the authenticated user<br/>
        /// Removes the public membership for the authenticated user from the specified organization, unless public visibility is enforced by default.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsRemovePublicMembershipForAuthenticatedUserAsync(
            string org,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}