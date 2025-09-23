
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Groups of organization members that gives permissions on specified repositories.
    /// </summary>
    public sealed partial class TeamFull
    {
        /// <summary>
        /// Unique identifier of the team<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDQ6VGVhbTE=
        /// </summary>
        /// <example>MDQ6VGVhbTE=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// URL for the team<br/>
        /// Example: https://api.github.com/organizations/1/team/1
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://github.com/orgs/rails/teams/core
        /// </summary>
        /// <example>https://github.com/orgs/rails/teams/core</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Name of the team<br/>
        /// Example: Developers
        /// </summary>
        /// <example>Developers</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: justice-league
        /// </summary>
        /// <example>justice-league</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Example: A great team.
        /// </summary>
        /// <example>A great team.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// The level of privacy this team should have<br/>
        /// Example: closed
        /// </summary>
        /// <example>closed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.TeamFullPrivacyJsonConverter))]
        public global::GitHub.TeamFullPrivacy? Privacy { get; set; }

        /// <summary>
        /// The notification setting the team has set<br/>
        /// Example: notifications_enabled
        /// </summary>
        /// <example>notifications_enabled</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.TeamFullNotificationSettingJsonConverter))]
        public global::GitHub.TeamFullNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// Permission that the team will have for its repositories<br/>
        /// Example: push
        /// </summary>
        /// <example>push</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Permission { get; set; }

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/1/members{/member}
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/1/members{/member}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MembersUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/organizations/1/team/1/repos
        /// </summary>
        /// <example>https://api.github.com/organizations/1/team/1/repos</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoriesUrl { get; set; }

        /// <summary>
        /// Groups of organization members that gives permissions on specified repositories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        public global::GitHub.NullableTeamSimple? Parent { get; set; }

        /// <summary>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MembersCount { get; set; }

        /// <summary>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReposCount { get; set; }

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
        /// Team Organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.TeamOrganization Organization { get; set; }

        /// <summary>
        /// The [distinguished name](https://www.ldap.com/ldap-dns-and-rdns) (DN) of the LDAP entry to map to a team.<br/>
        /// Example: cn=Enterprise Ops,ou=teams,dc=github,dc=com
        /// </summary>
        /// <example>cn=Enterprise Ops,ou=teams,dc=github,dc=com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ldap_dn")]
        public string? LdapDn { get; set; }

        /// <summary>
        /// The ownership type of the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.TeamFullTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.TeamFullType Type { get; set; }

        /// <summary>
        /// Unique identifier of the organization to which this team belongs<br/>
        /// Example: 37
        /// </summary>
        /// <example>37</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Unique identifier of the enterprise to which this team belongs<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_id")]
        public int? EnterpriseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamFull" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the team<br/>
        /// Example: 42
        /// </param>
        /// <param name="nodeId">
        /// Example: MDQ6VGVhbTE=
        /// </param>
        /// <param name="url">
        /// URL for the team<br/>
        /// Example: https://api.github.com/organizations/1/team/1
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/orgs/rails/teams/core
        /// </param>
        /// <param name="name">
        /// Name of the team<br/>
        /// Example: Developers
        /// </param>
        /// <param name="slug">
        /// Example: justice-league
        /// </param>
        /// <param name="description">
        /// Example: A great team.
        /// </param>
        /// <param name="privacy">
        /// The level of privacy this team should have<br/>
        /// Example: closed
        /// </param>
        /// <param name="notificationSetting">
        /// The notification setting the team has set<br/>
        /// Example: notifications_enabled
        /// </param>
        /// <param name="permission">
        /// Permission that the team will have for its repositories<br/>
        /// Example: push
        /// </param>
        /// <param name="membersUrl">
        /// Example: https://api.github.com/organizations/1/team/1/members{/member}
        /// </param>
        /// <param name="repositoriesUrl">
        /// Example: https://api.github.com/organizations/1/team/1/repos
        /// </param>
        /// <param name="parent">
        /// Groups of organization members that gives permissions on specified repositories.
        /// </param>
        /// <param name="membersCount">
        /// Example: 3
        /// </param>
        /// <param name="reposCount">
        /// Example: 10
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="organization">
        /// Team Organization
        /// </param>
        /// <param name="ldapDn">
        /// The [distinguished name](https://www.ldap.com/ldap-dns-and-rdns) (DN) of the LDAP entry to map to a team.<br/>
        /// Example: cn=Enterprise Ops,ou=teams,dc=github,dc=com
        /// </param>
        /// <param name="type">
        /// The ownership type of the team
        /// </param>
        /// <param name="organizationId">
        /// Unique identifier of the organization to which this team belongs<br/>
        /// Example: 37
        /// </param>
        /// <param name="enterpriseId">
        /// Unique identifier of the enterprise to which this team belongs<br/>
        /// Example: 42
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamFull(
            int id,
            string nodeId,
            string url,
            string htmlUrl,
            string name,
            string slug,
            string? description,
            string permission,
            string membersUrl,
            string repositoriesUrl,
            int membersCount,
            int reposCount,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::GitHub.TeamOrganization organization,
            global::GitHub.TeamFullType type,
            global::GitHub.TeamFullPrivacy? privacy,
            global::GitHub.TeamFullNotificationSetting? notificationSetting,
            global::GitHub.NullableTeamSimple? parent,
            string? ldapDn,
            int? organizationId,
            int? enterpriseId)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Permission = permission ?? throw new global::System.ArgumentNullException(nameof(permission));
            this.MembersUrl = membersUrl ?? throw new global::System.ArgumentNullException(nameof(membersUrl));
            this.RepositoriesUrl = repositoriesUrl ?? throw new global::System.ArgumentNullException(nameof(repositoriesUrl));
            this.MembersCount = membersCount;
            this.ReposCount = reposCount;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Type = type;
            this.Privacy = privacy;
            this.NotificationSetting = notificationSetting;
            this.Parent = parent;
            this.LdapDn = ldapDn;
            this.OrganizationId = organizationId;
            this.EnterpriseId = enterpriseId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamFull" /> class.
        /// </summary>
        public TeamFull()
        {
        }
    }
}