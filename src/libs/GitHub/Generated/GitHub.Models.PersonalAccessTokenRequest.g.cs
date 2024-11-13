
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Details of a Personal Access Token Request.
    /// </summary>
    public sealed partial class PersonalAccessTokenRequest
    {
        /// <summary>
        /// Unique identifier of the request for access via fine-grained personal access token. Used as the `pat_request_id` parameter in the list and review API calls.
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
        /// New requested permissions, categorized by type of permission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions_added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.PersonalAccessTokenRequestPermissionsAdded PermissionsAdded { get; set; }

        /// <summary>
        /// Requested permissions that elevate access for a previously approved request for access, categorized by type of permission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions_upgraded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.PersonalAccessTokenRequestPermissionsUpgraded PermissionsUpgraded { get; set; }

        /// <summary>
        /// Permissions requested, categorized by type of permission. This field incorporates `permissions_added` and `permissions_upgraded`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions_result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.PersonalAccessTokenRequestPermissionsResult PermissionsResult { get; set; }

        /// <summary>
        /// Type of repository selection requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.PersonalAccessTokenRequestRepositorySelectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.PersonalAccessTokenRequestRepositorySelection RepositorySelection { get; set; }

        /// <summary>
        /// The number of repositories the token is requesting access to. This field is only populated when `repository_selection` is `subset`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? RepositoryCount { get; set; }

        /// <summary>
        /// An array of repository objects the token is requesting access to. This field is only populated when `repository_selection` is `subset`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.PersonalAccessTokenRequestRepositorie>? Repositories { get; set; }

        /// <summary>
        /// Date and time when the request for access was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="PersonalAccessTokenRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the request for access via fine-grained personal access token. Used as the `pat_request_id` parameter in the list and review API calls.
        /// </param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="permissionsAdded">
        /// New requested permissions, categorized by type of permission.
        /// </param>
        /// <param name="permissionsUpgraded">
        /// Requested permissions that elevate access for a previously approved request for access, categorized by type of permission.
        /// </param>
        /// <param name="permissionsResult">
        /// Permissions requested, categorized by type of permission. This field incorporates `permissions_added` and `permissions_upgraded`.
        /// </param>
        /// <param name="repositorySelection">
        /// Type of repository selection requested.
        /// </param>
        /// <param name="repositoryCount">
        /// The number of repositories the token is requesting access to. This field is only populated when `repository_selection` is `subset`.
        /// </param>
        /// <param name="repositories">
        /// An array of repository objects the token is requesting access to. This field is only populated when `repository_selection` is `subset`.
        /// </param>
        /// <param name="createdAt">
        /// Date and time when the request for access was created.
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PersonalAccessTokenRequest(
            int id,
            global::GitHub.SimpleUser owner,
            global::GitHub.PersonalAccessTokenRequestPermissionsAdded permissionsAdded,
            global::GitHub.PersonalAccessTokenRequestPermissionsUpgraded permissionsUpgraded,
            global::GitHub.PersonalAccessTokenRequestPermissionsResult permissionsResult,
            global::GitHub.PersonalAccessTokenRequestRepositorySelection repositorySelection,
            int? repositoryCount,
            global::System.Collections.Generic.IList<global::GitHub.PersonalAccessTokenRequestRepositorie>? repositories,
            string createdAt,
            int tokenId,
            string tokenName,
            bool tokenExpired,
            string? tokenExpiresAt,
            string? tokenLastUsedAt)
        {
            this.Id = id;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.PermissionsAdded = permissionsAdded ?? throw new global::System.ArgumentNullException(nameof(permissionsAdded));
            this.PermissionsUpgraded = permissionsUpgraded ?? throw new global::System.ArgumentNullException(nameof(permissionsUpgraded));
            this.PermissionsResult = permissionsResult ?? throw new global::System.ArgumentNullException(nameof(permissionsResult));
            this.RepositorySelection = repositorySelection;
            this.RepositoryCount = repositoryCount;
            this.Repositories = repositories ?? throw new global::System.ArgumentNullException(nameof(repositories));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.TokenId = tokenId;
            this.TokenName = tokenName ?? throw new global::System.ArgumentNullException(nameof(tokenName));
            this.TokenExpired = tokenExpired;
            this.TokenExpiresAt = tokenExpiresAt ?? throw new global::System.ArgumentNullException(nameof(tokenExpiresAt));
            this.TokenLastUsedAt = tokenLastUsedAt ?? throw new global::System.ArgumentNullException(nameof(tokenLastUsedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalAccessTokenRequest" /> class.
        /// </summary>
        public PersonalAccessTokenRequest()
        {
        }
    }
}