
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsSetGithubActionsPermissionsRepositoryRequest
    {
        /// <summary>
        /// Whether GitHub Actions is enabled on the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AllowedActionsJsonConverter))]
        public global::GitHub.AllowedActions? AllowedActions { get; set; }

        /// <summary>
        /// Whether actions must be pinned to a full-length commit SHA.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha_pinning_required")]
        public bool? ShaPinningRequired { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetGithubActionsPermissionsRepositoryRequest" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether GitHub Actions is enabled on the repository.
        /// </param>
        /// <param name="allowedActions">
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </param>
        /// <param name="shaPinningRequired">
        /// Whether actions must be pinned to a full-length commit SHA.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsSetGithubActionsPermissionsRepositoryRequest(
            bool enabled,
            global::GitHub.AllowedActions? allowedActions,
            bool? shaPinningRequired)
        {
            this.Enabled = enabled;
            this.AllowedActions = allowedActions;
            this.ShaPinningRequired = shaPinningRequired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetGithubActionsPermissionsRepositoryRequest" /> class.
        /// </summary>
        public ActionsSetGithubActionsPermissionsRepositoryRequest()
        {
        }
    }
}