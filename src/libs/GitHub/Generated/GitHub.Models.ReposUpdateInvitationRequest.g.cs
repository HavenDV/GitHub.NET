
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposUpdateInvitationRequest
    {
        /// <summary>
        /// The permissions that the associated user will have on the repository. Valid values are `read`, `write`, `maintain`, `triage`, and `admin`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.ReposUpdateInvitationRequestPermissionsJsonConverter))]
        public global::GitHub.ReposUpdateInvitationRequestPermissions? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateInvitationRequest" /> class.
        /// </summary>
        /// <param name="permissions">
        /// The permissions that the associated user will have on the repository. Valid values are `read`, `write`, `maintain`, `triage`, and `admin`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposUpdateInvitationRequest(
            global::GitHub.ReposUpdateInvitationRequestPermissions? permissions)
        {
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateInvitationRequest" /> class.
        /// </summary>
        public ReposUpdateInvitationRequest()
        {
        }
    }
}