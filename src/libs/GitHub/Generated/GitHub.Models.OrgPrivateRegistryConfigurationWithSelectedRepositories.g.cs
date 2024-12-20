
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Private registry configuration for an organization
    /// </summary>
    public sealed partial class OrgPrivateRegistryConfigurationWithSelectedRepositories
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryTypeJsonConverter))]
        public global::GitHub.OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType RegistryType { get; set; }

        /// <summary>
        /// The username to use when authenticating with the private registry.<br/>
        /// Example: monalisa
        /// </summary>
        /// <example>monalisa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Which type of organization repositories have access to the private registry. `selected` means only the repositories specified by `selected_repository_ids` can access the private registry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility Visibility { get; set; }

        /// <summary>
        /// An array of repository IDs that can access the organization private registry when `visibility` is set to `selected`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repository_ids")]
        public global::System.Collections.Generic.IList<int>? SelectedRepositoryIds { get; set; }

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
        /// Initializes a new instance of the <see cref="OrgPrivateRegistryConfigurationWithSelectedRepositories" /> class.
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
        /// Which type of organization repositories have access to the private registry. `selected` means only the repositories specified by `selected_repository_ids` can access the private registry.
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository IDs that can access the organization private registry when `visibility` is set to `selected`.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrgPrivateRegistryConfigurationWithSelectedRepositories(
            string name,
            global::GitHub.OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility visibility,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::GitHub.OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType registryType,
            string? username,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Visibility = visibility;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.RegistryType = registryType;
            this.Username = username;
            this.SelectedRepositoryIds = selectedRepositoryIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgPrivateRegistryConfigurationWithSelectedRepositories" /> class.
        /// </summary>
        public OrgPrivateRegistryConfigurationWithSelectedRepositories()
        {
        }
    }
}