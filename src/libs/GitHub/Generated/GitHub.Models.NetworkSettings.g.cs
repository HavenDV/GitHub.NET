
#nullable enable

namespace GitHub
{
    /// <summary>
    /// A hosted compute network settings resource.
    /// </summary>
    public sealed partial class NetworkSettings
    {
        /// <summary>
        /// The unique identifier of the network settings resource.<br/>
        /// Example: 220F78DACB92BBFBC5E6F22DE1CCF52309D
        /// </summary>
        /// <example>220F78DACB92BBFBC5E6F22DE1CCF52309D</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The identifier of the network configuration that is using this settings resource.<br/>
        /// Example: 934E208B3EE0BD60CF5F752C426BFB53562
        /// </summary>
        /// <example>934E208B3EE0BD60CF5F752C426BFB53562</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_configuration_id")]
        public string? NetworkConfigurationId { get; set; }

        /// <summary>
        /// The name of the network settings resource.<br/>
        /// Example: my-network-settings
        /// </summary>
        /// <example>my-network-settings</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The subnet this network settings resource is configured for.<br/>
        /// Example: /subscriptions/14839728-3ad9-43ab-bd2b-fa6ad0f75e2a/resourceGroups/my-rg/providers/Microsoft.Network/virtualNetworks/my-vnet/subnets/my-subnet
        /// </summary>
        /// <example>/subscriptions/14839728-3ad9-43ab-bd2b-fa6ad0f75e2a/resourceGroups/my-rg/providers/Microsoft.Network/virtualNetworks/my-vnet/subnets/my-subnet</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subnet_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubnetId { get; set; }

        /// <summary>
        /// The location of the subnet this network settings resource is configured for.<br/>
        /// Example: eastus
        /// </summary>
        /// <example>eastus</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkSettings" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the network settings resource.<br/>
        /// Example: 220F78DACB92BBFBC5E6F22DE1CCF52309D
        /// </param>
        /// <param name="networkConfigurationId">
        /// The identifier of the network configuration that is using this settings resource.<br/>
        /// Example: 934E208B3EE0BD60CF5F752C426BFB53562
        /// </param>
        /// <param name="name">
        /// The name of the network settings resource.<br/>
        /// Example: my-network-settings
        /// </param>
        /// <param name="subnetId">
        /// The subnet this network settings resource is configured for.<br/>
        /// Example: /subscriptions/14839728-3ad9-43ab-bd2b-fa6ad0f75e2a/resourceGroups/my-rg/providers/Microsoft.Network/virtualNetworks/my-vnet/subnets/my-subnet
        /// </param>
        /// <param name="region">
        /// The location of the subnet this network settings resource is configured for.<br/>
        /// Example: eastus
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkSettings(
            string id,
            string name,
            string subnetId,
            string region,
            string? networkConfigurationId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SubnetId = subnetId ?? throw new global::System.ArgumentNullException(nameof(subnetId));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.NetworkConfigurationId = networkConfigurationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkSettings" /> class.
        /// </summary>
        public NetworkSettings()
        {
        }
    }
}