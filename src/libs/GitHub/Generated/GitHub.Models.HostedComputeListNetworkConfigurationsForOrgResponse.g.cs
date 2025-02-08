
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HostedComputeListNetworkConfigurationsForOrgResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_configurations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.NetworkConfiguration> NetworkConfigurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedComputeListNetworkConfigurationsForOrgResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="networkConfigurations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedComputeListNetworkConfigurationsForOrgResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::GitHub.NetworkConfiguration> networkConfigurations)
        {
            this.TotalCount = totalCount;
            this.NetworkConfigurations = networkConfigurations ?? throw new global::System.ArgumentNullException(nameof(networkConfigurations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedComputeListNetworkConfigurationsForOrgResponse" /> class.
        /// </summary>
        public HostedComputeListNetworkConfigurationsForOrgResponse()
        {
        }
    }
}