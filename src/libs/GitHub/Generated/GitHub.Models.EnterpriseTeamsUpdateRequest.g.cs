
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterpriseTeamsUpdateRequest
    {
        /// <summary>
        /// A new name for the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A new description for the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Retired: this field is no longer supported.<br/>
        /// Whether the enterprise team should be reflected in each organization.<br/>
        /// This value cannot be changed.<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_to_organizations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.EnterpriseTeamsUpdateRequestSyncToOrganizationsJsonConverter))]
        public global::GitHub.EnterpriseTeamsUpdateRequestSyncToOrganizations? SyncToOrganizations { get; set; }

        /// <summary>
        /// The ID of the IdP group to assign team membership with. The new IdP group will replace the existing one, or replace existing direct members if the team isn't currently linked to an IdP group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeamsUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A new name for the team.
        /// </param>
        /// <param name="description">
        /// A new description for the team.
        /// </param>
        /// <param name="syncToOrganizations">
        /// Retired: this field is no longer supported.<br/>
        /// Whether the enterprise team should be reflected in each organization.<br/>
        /// This value cannot be changed.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="groupId">
        /// The ID of the IdP group to assign team membership with. The new IdP group will replace the existing one, or replace existing direct members if the team isn't currently linked to an IdP group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseTeamsUpdateRequest(
            string? name,
            string? description,
            global::GitHub.EnterpriseTeamsUpdateRequestSyncToOrganizations? syncToOrganizations,
            string? groupId)
        {
            this.Name = name;
            this.Description = description;
            this.SyncToOrganizations = syncToOrganizations;
            this.GroupId = groupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeamsUpdateRequest" /> class.
        /// </summary>
        public EnterpriseTeamsUpdateRequest()
        {
        }
    }
}