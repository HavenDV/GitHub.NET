
#nullable enable

namespace GitHub
{
    /// <summary>
    /// A hosted compute network configuration.
    /// </summary>
    public sealed partial class NetworkConfiguration
    {
        /// <summary>
        /// The unique identifier of the network configuration.<br/>
        /// Example: 123ABC456DEF789
        /// </summary>
        /// <example>123ABC456DEF789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the network configuration.<br/>
        /// Example: my-network-configuration
        /// </summary>
        /// <example>my-network-configuration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The hosted compute service the network configuration supports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_service")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.NetworkConfigurationComputeServiceJsonConverter))]
        public global::GitHub.NetworkConfigurationComputeService? ComputeService { get; set; }

        /// <summary>
        /// The unique identifier of each network settings in the configuration.<br/>
        /// Example: 123ABC456DEF789
        /// </summary>
        /// <example>123ABC456DEF789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_settings_ids")]
        public global::System.Collections.Generic.IList<string>? NetworkSettingsIds { get; set; }

        /// <summary>
        /// The time at which the network configuration was created, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkConfiguration" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the network configuration.<br/>
        /// Example: 123ABC456DEF789
        /// </param>
        /// <param name="name">
        /// The name of the network configuration.<br/>
        /// Example: my-network-configuration
        /// </param>
        /// <param name="computeService">
        /// The hosted compute service the network configuration supports.
        /// </param>
        /// <param name="networkSettingsIds">
        /// The unique identifier of each network settings in the configuration.<br/>
        /// Example: 123ABC456DEF789
        /// </param>
        /// <param name="createdOn">
        /// The time at which the network configuration was created, in ISO 8601 format.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public NetworkConfiguration(
            string id,
            string name,
            global::System.DateTime? createdOn,
            global::GitHub.NetworkConfigurationComputeService? computeService,
            global::System.Collections.Generic.IList<string>? networkSettingsIds)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedOn = createdOn;
            this.ComputeService = computeService;
            this.NetworkSettingsIds = networkSettingsIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkConfiguration" /> class.
        /// </summary>
        public NetworkConfiguration()
        {
        }
    }
}