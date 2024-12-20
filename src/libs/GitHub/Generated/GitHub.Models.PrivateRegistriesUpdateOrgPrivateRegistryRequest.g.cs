
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateRegistriesUpdateOrgPrivateRegistryRequest
    {
        /// <summary>
        /// The registry type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryTypeJsonConverter))]
        public global::GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType? RegistryType { get; set; }

        /// <summary>
        /// The username to use when authenticating with the private registry. This field should be omitted if the private registry does not require a username for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// The value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get private registries public key for an organization](https://docs.github.com/rest/private-registries/organization-configurations#get-private-registries-public-key-for-an-organization) endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_value")]
        public string? EncryptedValue { get; set; }

        /// <summary>
        /// The ID of the key you used to encrypt the secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        public string? KeyId { get; set; }

        /// <summary>
        /// Which type of organization repositories have access to the private registry. `selected` means only the repositories specified by `selected_repository_ids` can access the private registry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibilityJsonConverter))]
        public global::GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// An array of repository IDs that can access the organization private registry. You can only provide a list of repository IDs when `visibility` is set to `selected`. This field should be omitted if `visibility` is set to `all` or `private`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repository_ids")]
        public global::System.Collections.Generic.IList<int>? SelectedRepositoryIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateRegistriesUpdateOrgPrivateRegistryRequest" /> class.
        /// </summary>
        /// <param name="registryType">
        /// The registry type.
        /// </param>
        /// <param name="username">
        /// The username to use when authenticating with the private registry. This field should be omitted if the private registry does not require a username for authentication.
        /// </param>
        /// <param name="encryptedValue">
        /// The value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get private registries public key for an organization](https://docs.github.com/rest/private-registries/organization-configurations#get-private-registries-public-key-for-an-organization) endpoint.
        /// </param>
        /// <param name="keyId">
        /// The ID of the key you used to encrypt the secret.
        /// </param>
        /// <param name="visibility">
        /// Which type of organization repositories have access to the private registry. `selected` means only the repositories specified by `selected_repository_ids` can access the private registry.
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository IDs that can access the organization private registry. You can only provide a list of repository IDs when `visibility` is set to `selected`. This field should be omitted if `visibility` is set to `all` or `private`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PrivateRegistriesUpdateOrgPrivateRegistryRequest(
            global::GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType? registryType,
            string? username,
            string? encryptedValue,
            string? keyId,
            global::GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility? visibility,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds)
        {
            this.RegistryType = registryType;
            this.Username = username;
            this.EncryptedValue = encryptedValue;
            this.KeyId = keyId;
            this.Visibility = visibility;
            this.SelectedRepositoryIds = selectedRepositoryIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateRegistriesUpdateOrgPrivateRegistryRequest" /> class.
        /// </summary>
        public PrivateRegistriesUpdateOrgPrivateRegistryRequest()
        {
        }
    }
}