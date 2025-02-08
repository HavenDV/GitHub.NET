
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Team Membership
    /// </summary>
    public sealed partial class TeamMembership
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The role of the user in the team.<br/>
        /// Default Value: member<br/>
        /// Example: member
        /// </summary>
        /// <default>global::GitHub.TeamMembershipRole.Member</default>
        /// <example>member</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.TeamMembershipRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.TeamMembershipRole Role { get; set; } = global::GitHub.TeamMembershipRole.Member;

        /// <summary>
        /// The state of the user's membership in the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.TeamMembershipStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.TeamMembershipState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembership" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="role">
        /// The role of the user in the team.<br/>
        /// Default Value: member<br/>
        /// Example: member
        /// </param>
        /// <param name="state">
        /// The state of the user's membership in the team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMembership(
            string url,
            global::GitHub.TeamMembershipRole role,
            global::GitHub.TeamMembershipState state)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Role = role;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMembership" /> class.
        /// </summary>
        public TeamMembership()
        {
        }
    }
}