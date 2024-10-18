#nullable enable

namespace GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Set primary email visibility for the authenticated user<br/>
        /// Sets the visibility for your primary email addresses.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Email>> UsersSetPrimaryEmailVisibilityForAuthenticatedUserAsync(
            global::GitHub.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set primary email visibility for the authenticated user<br/>
        /// Sets the visibility for your primary email addresses.
        /// </summary>
        /// <param name="visibility">
        /// Denotes whether an email is publicly visible.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Email>> UsersSetPrimaryEmailVisibilityForAuthenticatedUserAsync(
            global::GitHub.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility visibility,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}