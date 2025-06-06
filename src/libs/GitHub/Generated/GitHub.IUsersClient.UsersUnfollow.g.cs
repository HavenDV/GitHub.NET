#nullable enable

namespace GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Unfollow a user<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user:follow` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task UsersUnfollowAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}