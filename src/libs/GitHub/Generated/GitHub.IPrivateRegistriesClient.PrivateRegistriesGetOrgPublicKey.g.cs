#nullable enable

namespace GitHub
{
    public partial interface IPrivateRegistriesClient
    {
        /// <summary>
        /// Get private registries public key for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Gets the org public key, which is needed to encrypt private registry secrets. You need to encrypt a secret before you can create or update secrets.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.PrivateRegistriesGetOrgPublicKeyResponse> PrivateRegistriesGetOrgPublicKeyAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}