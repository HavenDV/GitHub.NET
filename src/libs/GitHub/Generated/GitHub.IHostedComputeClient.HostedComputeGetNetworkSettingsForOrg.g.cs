#nullable enable

namespace GitHub
{
    public partial interface IHostedComputeClient
    {
        /// <summary>
        /// Get a hosted compute network settings resource for an organization<br/>
        /// Gets a hosted compute network settings resource configured for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:network_configurations` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="networkSettingsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.NetworkSettings> HostedComputeGetNetworkSettingsForOrgAsync(
            string org,
            string networkSettingsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}