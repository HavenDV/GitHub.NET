#nullable enable

namespace GitHub
{
    public partial interface IOidcClient
    {
        /// <summary>
        /// Get the customization template for an OIDC subject claim for an organization<br/>
        /// Gets the customization template for an OpenID Connect (OIDC) subject claim.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.OidcCustomSub> OidcGetOidcCustomSubTemplateForOrgAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}