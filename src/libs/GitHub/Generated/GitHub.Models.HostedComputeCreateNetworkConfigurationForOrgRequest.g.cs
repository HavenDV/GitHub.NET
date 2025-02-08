
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HostedComputeCreateNetworkConfigurationForOrgRequest
    {
        /// <summary>
        /// Name of the network configuration. Must be between 1 and 100 characters and may only contain upper and lowercase letters a-z, numbers 0-9, '.', '-', and '_'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The hosted compute service to use for the network configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_service")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.HostedComputeCreateNetworkConfigurationForOrgRequestComputeServiceJsonConverter))]
        public global::GitHub.HostedComputeCreateNetworkConfigurationForOrgRequestComputeService? ComputeService { get; set; }

        /// <summary>
        /// The identifier of the network settings to use for the network configuration. Exactly one network settings must be specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_settings_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> NetworkSettingsIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedComputeCreateNetworkConfigurationForOrgRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the network configuration. Must be between 1 and 100 characters and may only contain upper and lowercase letters a-z, numbers 0-9, '.', '-', and '_'.
        /// </param>
        /// <param name="computeService">
        /// The hosted compute service to use for the network configuration.
        /// </param>
        /// <param name="networkSettingsIds">
        /// The identifier of the network settings to use for the network configuration. Exactly one network settings must be specified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedComputeCreateNetworkConfigurationForOrgRequest(
            string name,
            global::System.Collections.Generic.IList<string> networkSettingsIds,
            global::GitHub.HostedComputeCreateNetworkConfigurationForOrgRequestComputeService? computeService)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NetworkSettingsIds = networkSettingsIds ?? throw new global::System.ArgumentNullException(nameof(networkSettingsIds));
            this.ComputeService = computeService;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedComputeCreateNetworkConfigurationForOrgRequest" /> class.
        /// </summary>
        public HostedComputeCreateNetworkConfigurationForOrgRequest()
        {
        }
    }
}