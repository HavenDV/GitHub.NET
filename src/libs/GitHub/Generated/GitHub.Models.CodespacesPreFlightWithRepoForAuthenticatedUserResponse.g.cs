
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesPreFlightWithRepoForAuthenticatedUserResponse
    {
        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable_owner")]
        public global::GitHub.SimpleUser? BillableOwner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaults")]
        public global::GitHub.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults? Defaults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPreFlightWithRepoForAuthenticatedUserResponse" /> class.
        /// </summary>
        /// <param name="billableOwner">
        /// A GitHub user.
        /// </param>
        /// <param name="defaults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodespacesPreFlightWithRepoForAuthenticatedUserResponse(
            global::GitHub.SimpleUser? billableOwner,
            global::GitHub.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults? defaults)
        {
            this.BillableOwner = billableOwner;
            this.Defaults = defaults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPreFlightWithRepoForAuthenticatedUserResponse" /> class.
        /// </summary>
        public CodespacesPreFlightWithRepoForAuthenticatedUserResponse()
        {
        }
    }
}