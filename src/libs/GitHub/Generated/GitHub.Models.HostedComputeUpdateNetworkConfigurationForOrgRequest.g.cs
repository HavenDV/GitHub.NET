
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HostedComputeUpdateNetworkConfigurationForOrgRequest
    {
        /// <summary>
        /// Name of the network configuration. Must be between 1 and 100 characters and may only contain upper and lowercase letters a-z, numbers 0-9, '.', '-', and '_'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The hosted compute service to use for the network configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_service")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.HostedComputeUpdateNetworkConfigurationForOrgRequestComputeServiceJsonConverter))]
        public global::GitHub.HostedComputeUpdateNetworkConfigurationForOrgRequestComputeService? ComputeService { get; set; }

        /// <summary>
        /// The identifier of the network settings to use for the network configuration. Exactly one network settings must be specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_settings_ids")]
        public global::System.Collections.Generic.IList<string>? NetworkSettingsIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedComputeUpdateNetworkConfigurationForOrgRequest" /> class.
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public HostedComputeUpdateNetworkConfigurationForOrgRequest(
            string? name,
            global::GitHub.HostedComputeUpdateNetworkConfigurationForOrgRequestComputeService? computeService,
            global::System.Collections.Generic.IList<string>? networkSettingsIds)
        {
            this.Name = name;
            this.ComputeService = computeService;
            this.NetworkSettingsIds = networkSettingsIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedComputeUpdateNetworkConfigurationForOrgRequest" /> class.
        /// </summary>
        public HostedComputeUpdateNetworkConfigurationForOrgRequest()
        {
        }
    }
}