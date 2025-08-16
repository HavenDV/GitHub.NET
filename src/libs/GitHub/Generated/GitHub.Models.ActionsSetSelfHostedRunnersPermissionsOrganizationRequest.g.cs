
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsSetSelfHostedRunnersPermissionsOrganizationRequest
    {
        /// <summary>
        /// The policy that controls whether self-hosted runners can be used in the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_repositories")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.ActionsSetSelfHostedRunnersPermissionsOrganizationRequestEnabledRepositoriesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.ActionsSetSelfHostedRunnersPermissionsOrganizationRequestEnabledRepositories EnabledRepositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetSelfHostedRunnersPermissionsOrganizationRequest" /> class.
        /// </summary>
        /// <param name="enabledRepositories">
        /// The policy that controls whether self-hosted runners can be used in the organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsSetSelfHostedRunnersPermissionsOrganizationRequest(
            global::GitHub.ActionsSetSelfHostedRunnersPermissionsOrganizationRequestEnabledRepositories enabledRepositories)
        {
            this.EnabledRepositories = enabledRepositories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetSelfHostedRunnersPermissionsOrganizationRequest" /> class.
        /// </summary>
        public ActionsSetSelfHostedRunnersPermissionsOrganizationRequest()
        {
        }
    }
}