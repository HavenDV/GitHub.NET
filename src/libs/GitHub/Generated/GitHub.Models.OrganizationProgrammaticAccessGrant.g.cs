
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Minimal representation of an organization programmatic access grant for enumerations
    /// </summary>
    public sealed partial class OrganizationProgrammaticAccessGrant
    {
        /// <summary>
        /// Unique identifier of the fine-grained personal access token grant. The `pat_id` used to get details about an approved fine-grained personal access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SimpleUser Owner { get; set; }

        /// <summary>
        /// Type of repository selection requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OrganizationProgrammaticAccessGrantRepositorySelectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.OrganizationProgrammaticAccessGrantRepositorySelection RepositorySelection { get; set; }

        /// <summary>
        /// URL to the list of repositories the fine-grained personal access token can access. Only follow when `repository_selection` is `subset`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoriesUrl { get; set; }

        /// <summary>
        /// Permissions requested, categorized by type of permission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.OrganizationProgrammaticAccessGrantPermissions Permissions { get; set; }

        /// <summary>
        /// Date and time when the fine-grained personal access token was approved to access the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_granted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessGrantedAt { get; set; }

        /// <summary>
        /// Unique identifier of the user's token. This field can also be found in audit log events and the organization's settings for their PAT grants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TokenId { get; set; }

        /// <summary>
        /// The name given to the user's token. This field can also be found in an organization's settings page for Active Tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenName { get; set; }

        /// <summary>
        /// Whether the associated fine-grained personal access token has expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_expired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TokenExpired { get; set; }

        /// <summary>
        /// Date and time when the associated fine-grained personal access token expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? TokenExpiresAt { get; set; }

        /// <summary>
        /// Date and time when the associated fine-grained personal access token was last used for authentication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_last_used_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? TokenLastUsedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProgrammaticAccessGrant" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the fine-grained personal access token grant. The `pat_id` used to get details about an approved fine-grained personal access token.
        /// </param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="repositorySelection">
        /// Type of repository selection requested.
        /// </param>
        /// <param name="repositoriesUrl">
        /// URL to the list of repositories the fine-grained personal access token can access. Only follow when `repository_selection` is `subset`.
        /// </param>
        /// <param name="permissions">
        /// Permissions requested, categorized by type of permission.
        /// </param>
        /// <param name="accessGrantedAt">
        /// Date and time when the fine-grained personal access token was approved to access the organization.
        /// </param>
        /// <param name="tokenId">
        /// Unique identifier of the user's token. This field can also be found in audit log events and the organization's settings for their PAT grants.
        /// </param>
        /// <param name="tokenName">
        /// The name given to the user's token. This field can also be found in an organization's settings page for Active Tokens.
        /// </param>
        /// <param name="tokenExpired">
        /// Whether the associated fine-grained personal access token has expired.
        /// </param>
        /// <param name="tokenExpiresAt">
        /// Date and time when the associated fine-grained personal access token expires.
        /// </param>
        /// <param name="tokenLastUsedAt">
        /// Date and time when the associated fine-grained personal access token was last used for authentication.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationProgrammaticAccessGrant(
            int id,
            global::GitHub.SimpleUser owner,
            global::GitHub.OrganizationProgrammaticAccessGrantRepositorySelection repositorySelection,
            string repositoriesUrl,
            global::GitHub.OrganizationProgrammaticAccessGrantPermissions permissions,
            string accessGrantedAt,
            int tokenId,
            string tokenName,
            bool tokenExpired,
            string? tokenExpiresAt,
            string? tokenLastUsedAt)
        {
            this.Id = id;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.RepositorySelection = repositorySelection;
            this.RepositoriesUrl = repositoriesUrl ?? throw new global::System.ArgumentNullException(nameof(repositoriesUrl));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.AccessGrantedAt = accessGrantedAt ?? throw new global::System.ArgumentNullException(nameof(accessGrantedAt));
            this.TokenId = tokenId;
            this.TokenName = tokenName ?? throw new global::System.ArgumentNullException(nameof(tokenName));
            this.TokenExpired = tokenExpired;
            this.TokenExpiresAt = tokenExpiresAt ?? throw new global::System.ArgumentNullException(nameof(tokenExpiresAt));
            this.TokenLastUsedAt = tokenLastUsedAt ?? throw new global::System.ArgumentNullException(nameof(tokenLastUsedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProgrammaticAccessGrant" /> class.
        /// </summary>
        public OrganizationProgrammaticAccessGrant()
        {
        }
    }
}