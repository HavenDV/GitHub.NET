#nullable enable

namespace GitHub
{
    public partial interface IPrivateRegistriesClient
    {
        /// <summary>
        /// Delete a private registry for an organization<br/>
        /// Delete a private registry configuration at the organization-level.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task PrivateRegistriesDeleteOrgPrivateRegistryAsync(
            string org,
            string secretName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}