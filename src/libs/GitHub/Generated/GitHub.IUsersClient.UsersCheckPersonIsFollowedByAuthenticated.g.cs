#nullable enable

namespace GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Check if a person is followed by the authenticated user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task UsersCheckPersonIsFollowedByAuthenticatedAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}