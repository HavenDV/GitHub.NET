
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnterpriseTeamMembershipsBulkRemoveRequest
    {
        /// <summary>
        /// The GitHub user handles to be removed from the team.
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
        /// Initializes a new instance of the <see cref="EnterpriseTeamMembershipsBulkRemoveRequest" /> class.
        /// </summary>
        /// <param name="usernames">
        /// The GitHub user handles to be removed from the team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnterpriseTeamMembershipsBulkRemoveRequest(
            global::System.Collections.Generic.IList<string> usernames)
        {
            this.Usernames = usernames ?? throw new global::System.ArgumentNullException(nameof(usernames));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseTeamMembershipsBulkRemoveRequest" /> class.
        /// </summary>
        public EnterpriseTeamMembershipsBulkRemoveRequest()
        {
        }
    }
}