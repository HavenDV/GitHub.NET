#nullable enable

namespace GitHub
{
    public partial interface IHostedComputeClient
    {
        /// <summary>
        /// List hosted compute network configurations for an organization<br/>
        /// Lists all hosted compute network configurations configured in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:network_configurations` scope to use this endpoint.
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
        global::System.Threading.Tasks.Task<global::GitHub.HostedComputeListNetworkConfigurationsForOrgResponse> HostedComputeListNetworkConfigurationsForOrgAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}