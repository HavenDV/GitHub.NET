
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Private registry configuration for an organization
    /// </summary>
    public sealed partial class OrgPrivateRegistryConfiguration
    {
        /// <summary>
        /// The name of the private registry configuration.<br/>
        /// Example: MAVEN_REPOSITORY_SECRET
        /// </summary>
        /// <example>MAVEN_REPOSITORY_SECRET</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The registry type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OrgPrivateRegistryConfigurationRegistryTypeJsonConverter))]
        public global::GitHub.OrgPrivateRegistryConfigurationRegistryType RegistryType { get; set; }

        /// <summary>
        /// The username to use when authenticating with the private registry.<br/>
        /// Example: monalisa
        /// </summary>
        /// <example>monalisa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Which type of organization repositories have access to the private registry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OrgPrivateRegistryConfigurationVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.OrgPrivateRegistryConfigurationVisibility Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgPrivateRegistryConfiguration" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the private registry configuration.<br/>
        /// Example: MAVEN_REPOSITORY_SECRET
        /// </param>
        /// <param name="registryType">
        /// The registry type.
        /// </param>
        /// <param name="username">
        /// The username to use when authenticating with the private registry.<br/>
        /// Example: monalisa
        /// </param>
        /// <param name="visibility">
        /// Which type of organization repositories have access to the private registry.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgPrivateRegistryConfiguration(
            string name,
            global::GitHub.OrgPrivateRegistryConfigurationVisibility visibility,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::GitHub.OrgPrivateRegistryConfigurationRegistryType registryType,
            string? username)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Visibility = visibility;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.RegistryType = registryType;
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgPrivateRegistryConfiguration" /> class.
        /// </summary>
        public OrgPrivateRegistryConfiguration()
        {
        }
    }
}