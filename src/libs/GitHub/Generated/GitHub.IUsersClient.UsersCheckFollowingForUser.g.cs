#nullable enable

namespace GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Check if a user follows another user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="targetUser"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task UsersCheckFollowingForUserAsync(
            string username,
            string targetUser,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}