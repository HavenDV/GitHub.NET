
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsSetGithubActionsPermissionsOrganizationRequest
    {
        /// <summary>
        /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_repositories")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.EnabledRepositoriesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.EnabledRepositories EnabledRepositories { get; set; }

        /// <summary>
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AllowedActionsJsonConverter))]
        public global::GitHub.AllowedActions? AllowedActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetGithubActionsPermissionsOrganizationRequest" /> class.
        /// </summary>
        /// <param name="enabledRepositories">
        /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions.
        /// </param>
        /// <param name="allowedActions">
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsSetGithubActionsPermissionsOrganizationRequest(
            global::GitHub.EnabledRepositories enabledRepositories,
            global::GitHub.AllowedActions? allowedActions)
        {
            this.EnabledRepositories = enabledRepositories;
            this.AllowedActions = allowedActions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetGithubActionsPermissionsOrganizationRequest" /> class.
        /// </summary>
        public ActionsSetGithubActionsPermissionsOrganizationRequest()
        {
        }
    }
}