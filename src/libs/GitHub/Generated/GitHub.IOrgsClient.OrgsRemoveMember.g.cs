#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Remove an organization member<br/>
        /// Removing a user from this list will remove them from all teams and they will no longer have any access to the organization's repositories.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; If a user has both direct membership in the organization as well as indirect membership via an enterprise team, only their direct membership will be removed. Their indirect membership via an enterprise team remains until the user is removed from the enterprise team.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsRemoveMemberAsync(
            string org,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}