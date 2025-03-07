#nullable enable

namespace GitHub
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// Get an organization public key<br/>
        /// Gets your public key, which you need to encrypt secrets. You need to<br/>
        /// encrypt a secret before you can create or update secrets.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.DependabotPublicKey> DependabotGetOrgPublicKeyAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}