#nullable enable

namespace GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Delete a public SSH key for the authenticated user<br/>
        /// Removes a public SSH key from the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:public_key` scope to use this endpoint.
        /// </summary>
        /// <param name="keyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BasicError> UsersDeletePublicSshKeyForAuthenticatedUserAsync(
            int keyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}