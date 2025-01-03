#nullable enable

namespace GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Create a GPG key for the authenticated user<br/>
        /// Adds a GPG key to the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:gpg_key` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.GpgKey> UsersCreateGpgKeyForAuthenticatedUserAsync(
            global::GitHub.UsersCreateGpgKeyForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a GPG key for the authenticated user<br/>
        /// Adds a GPG key to the authenticated user's GitHub account.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:gpg_key` scope to use this endpoint.
        /// </summary>
        /// <param name="name">
        /// A descriptive name for the new key.
        /// </param>
        /// <param name="armoredPublicKey">
        /// A GPG key in ASCII-armored format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.GpgKey> UsersCreateGpgKeyForAuthenticatedUserAsync(
            string armoredPublicKey,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}