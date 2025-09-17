
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterpriseTeamMembershipsBulkAddRequest
    {
        /// <summary>
        /// The GitHub user handles to add to the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usernames")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Usernames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeamMembershipsBulkAddRequest" /> class.
        /// </summary>
        /// <param name="usernames">
        /// The GitHub user handles to add to the team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseTeamMembershipsBulkAddRequest(
            global::System.Collections.Generic.IList<string> usernames)
        {
            this.Usernames = usernames ?? throw new global::System.ArgumentNullException(nameof(usernames));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeamMembershipsBulkAddRequest" /> class.
        /// </summary>
        public EnterpriseTeamMembershipsBulkAddRequest()
        {
        }
    }
}