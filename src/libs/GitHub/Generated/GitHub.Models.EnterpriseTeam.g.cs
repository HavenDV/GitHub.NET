
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Group of enterprise owners and/or members
    /// </summary>
    public sealed partial class EnterpriseTeam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: disabled | all
        /// </summary>
        /// <example>disabled | all</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_to_organizations")]
        public string? SyncToOrganizations { get; set; }

        /// <summary>
        /// Example: disabled | all
        /// </summary>
        /// <example>disabled | all</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_selection_type")]
        public string? OrganizationSelectionType { get; set; }

        /// <summary>
        /// Example: 62ab9291-fae2-468e-974b-7e45096d5021
        /// </summary>
        /// <example>62ab9291-fae2-468e-974b-7e45096d5021</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// Example: Justice League
        /// </summary>
        /// <example>Justice League</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_name")]
        public string? GroupName { get; set; }

        /// <summary>
        /// Example: https://github.com/enterprises/dc/teams/justice-league
        /// </summary>
        /// <example>https://github.com/enterprises/dc/teams/justice-league</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MembersUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="EnterpriseTeam" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="slug"></param>
        /// <param name="url"></param>
        /// <param name="syncToOrganizations">
        /// Example: disabled | all
        /// </param>
        /// <param name="organizationSelectionType">
        /// Example: disabled | all
        /// </param>
        /// <param name="groupId">
        /// Example: 62ab9291-fae2-468e-974b-7e45096d5021
        /// </param>
        /// <param name="groupName">
        /// Example: Justice League
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/enterprises/dc/teams/justice-league
        /// </param>
        /// <param name="membersUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseTeam(
            long id,
            string name,
            string slug,
            string url,
            string htmlUrl,
            string membersUrl,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            string? syncToOrganizations,
            string? organizationSelectionType,
            string? groupId,
            string? groupName)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.MembersUrl = membersUrl ?? throw new global::System.ArgumentNullException(nameof(membersUrl));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Description = description;
            this.SyncToOrganizations = syncToOrganizations;
            this.OrganizationSelectionType = organizationSelectionType;
            this.GroupId = groupId;
            this.GroupName = groupName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeam" /> class.
        /// </summary>
        public EnterpriseTeam()
        {
        }
    }
}