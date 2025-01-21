#nullable enable

namespace GitHub
{
    public partial interface IHostedComputeClient
    {
        /// <summary>
        /// Create a hosted compute network configuration for an organization<br/>
        /// Creates a hosted compute network configuration for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:network_configurations` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.NetworkConfiguration> HostedComputeCreateNetworkConfigurationForOrgAsync(
            string org,
            global::GitHub.HostedComputeCreateNetworkConfigurationForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a hosted compute network configuration for an organization<br/>
        /// Creates a hosted compute network configuration for an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:network_configurations` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// Name of the network configuration. Must be between 1 and 100 characters and may only contain upper and lowercase letters a-z, numbers 0-9, '.', '-', and '_'.
        /// </param>
        /// <param name="computeService">
        /// The hosted compute service to use for the network configuration.
        /// </param>
        /// <param name="networkSettingsIds">
        /// The identifier of the network settings to use for the network configuration. Exactly one network settings must be specified.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.NetworkConfiguration> HostedComputeCreateNetworkConfigurationForOrgAsync(
            string org,
            string name,
            global::System.Collections.Generic.IList<string> networkSettingsIds,
            global::GitHub.HostedComputeCreateNetworkConfigurationForOrgRequestComputeService? computeService = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}