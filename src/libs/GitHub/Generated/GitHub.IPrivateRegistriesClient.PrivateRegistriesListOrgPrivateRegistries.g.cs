#nullable enable

namespace GitHub
{
    public partial interface IPrivateRegistriesClient
    {
        /// <summary>
        /// List private registries for an organization<br/>
        /// Lists all private registry configurations available at the organization-level without revealing their encrypted<br/>
        /// values.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.PrivateRegistriesListOrgPrivateRegistriesResponse> PrivateRegistriesListOrgPrivateRegistriesAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}