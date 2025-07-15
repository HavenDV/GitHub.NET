
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The membership between the user and the organization. Not present when the action is `member_invited`.
    /// </summary>
    public sealed partial class WebhooksMembership
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// Whether the user has direct membership in the organization.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("direct_membership")]
        public bool? DirectMembership { get; set; }

        /// <summary>
        /// The slugs of the enterprise teams providing the user with indirect membership in the organization.<br/>
        /// A limit of 100 enterprise team slugs is returned.<br/>
        /// Example: [ent:team-one, ent:team-two]
        /// </summary>
        /// <example>[ent:team-one, ent:team-two]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_teams_providing_indirect_membership")]
        public global::System.Collections.Generic.IList<string>? EnterpriseTeamsProvidingIndirectMembership { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhooksMembershipUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksMembership" /> class.
        /// </summary>
        /// <param name="organizationUrl"></param>
        /// <param name="role"></param>
        /// <param name="directMembership">
        /// Whether the user has direct membership in the organization.<br/>
        /// Example: true
        /// </param>
        /// <param name="enterpriseTeamsProvidingIndirectMembership">
        /// The slugs of the enterprise teams providing the user with indirect membership in the organization.<br/>
        /// A limit of 100 enterprise team slugs is returned.<br/>
        /// Example: [ent:team-one, ent:team-two]
        /// </param>
        /// <param name="state"></param>
        /// <param name="url"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksMembership(
            string organizationUrl,
            string role,
            string state,
            string url,
            global::GitHub.WebhooksMembershipUser? user,
            bool? directMembership,
            global::System.Collections.Generic.IList<string>? enterpriseTeamsProvidingIndirectMembership)
        {
            this.OrganizationUrl = organizationUrl ?? throw new global::System.ArgumentNullException(nameof(organizationUrl));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.DirectMembership = directMembership;
            this.EnterpriseTeamsProvidingIndirectMembership = enterpriseTeamsProvidingIndirectMembership;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksMembership" /> class.
        /// </summary>
        public WebhooksMembership()
        {
        }
    }
}