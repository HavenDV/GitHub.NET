#nullable enable

namespace GitHub
{
    public partial interface IHostedComputeClient
    {
        /// <summary>
        /// Delete a hosted compute network configuration from an organization<br/>
        /// Deletes a hosted compute network configuration from an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:network_configurations` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="networkConfigurationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task HostedComputeDeleteNetworkConfigurationFromOrgAsync(
            string org,
            string networkConfigurationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}