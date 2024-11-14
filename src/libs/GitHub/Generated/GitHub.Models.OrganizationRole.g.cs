
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Organization roles
    /// </summary>
    public sealed partial class OrganizationRole
    {
        /// <summary>
        /// The unique identifier of the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// The name of the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A short description about who this role is for or what permissions it grants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The system role from which this role inherits permissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OrganizationRoleBaseRoleJsonConverter))]
        public global::GitHub.OrganizationRoleBaseRole? BaseRole { get; set; }

        /// <summary>
        /// Source answers the question, "where did this role come from?"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OrganizationRoleSourceJsonConverter))]
        public global::GitHub.OrganizationRoleSource? Source { get; set; }

        /// <summary>
        /// A list of permissions included in this role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.NullableSimpleUser? Organization { get; set; }

        /// <summary>
        /// The date and time the role was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time the role was last updated.
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
        /// Initializes a new instance of the <see cref="OrganizationRole" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the role.
        /// </param>
        /// <param name="name">
        /// The name of the role.
        /// </param>
        /// <param name="description">
        /// A short description about who this role is for or what permissions it grants.
        /// </param>
        /// <param name="baseRole">
        /// The system role from which this role inherits permissions.
        /// </param>
        /// <param name="source">
        /// Source answers the question, "where did this role come from?"
        /// </param>
        /// <param name="permissions">
        /// A list of permissions included in this role.
        /// </param>
        /// <param name="organization">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the role was created.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the role was last updated.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrganizationRole(
            long id,
            string name,
            global::System.Collections.Generic.IList<string> permissions,
            global::GitHub.NullableSimpleUser? organization,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            global::GitHub.OrganizationRoleBaseRole? baseRole,
            global::GitHub.OrganizationRoleSource? source)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Description = description;
            this.BaseRole = baseRole;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationRole" /> class.
        /// </summary>
        public OrganizationRole()
        {
        }
    }
}