#nullable enable

namespace GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Add an email address for the authenticated user<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Email>> UsersAddEmailForAuthenticatedUserAsync(
            global::GitHub.OneOf<global::GitHub.UsersAddEmailForAuthenticatedUserRequest2, global::System.Collections.Generic.IList<string>, string> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add an email address for the authenticated user<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `user` scope to use this endpoint.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Email>> UsersAddEmailForAuthenticatedUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}