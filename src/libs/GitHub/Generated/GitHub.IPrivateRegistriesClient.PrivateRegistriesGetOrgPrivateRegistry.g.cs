#nullable enable

namespace GitHub
{
    public partial interface IPrivateRegistriesClient
    {
        /// <summary>
        /// Get a private registry for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Get the configuration of a single private registry defined for an organization, omitting its encrypted value.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.OrgPrivateRegistryConfiguration> PrivateRegistriesGetOrgPrivateRegistryAsync(
            string org,
            string secretName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}