#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Remove an organization member<br/>
        /// Removing a user from this list will remove them from all teams and they will no longer have any access to the organization's repositories.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BasicError> OrgsRemoveMemberAsync(
            string org,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}