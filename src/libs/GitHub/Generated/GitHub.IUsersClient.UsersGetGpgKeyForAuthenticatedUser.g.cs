#nullable enable

namespace GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get a GPG key for the authenticated user<br/>
        /// View extended details for a single GPG key.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:gpg_key` scope to use this endpoint.
        /// </summary>
        /// <param name="gpgKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.GpgKey> UsersGetGpgKeyForAuthenticatedUserAsync(
            int gpgKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}