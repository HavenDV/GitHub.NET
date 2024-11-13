#nullable enable

namespace GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get an SSH signing key for the authenticated user<br/>
        /// Gets extended details for an SSH signing key.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:ssh_signing_key` scope to use this endpoint.
        /// </summary>
        /// <param name="sshSigningKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.SshSigningKey> UsersGetSshSigningKeyForAuthenticatedUserAsync(
            int sshSigningKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}