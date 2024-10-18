#nullable enable

namespace GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get the authenticated user<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope in order for the response to include private profile information.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.OneOf<global::GitHub.PrivateUser, global::GitHub.PublicUser>> UsersGetAuthenticatedAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}