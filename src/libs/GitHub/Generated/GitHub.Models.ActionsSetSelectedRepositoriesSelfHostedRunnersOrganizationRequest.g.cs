
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsSetSelectedRepositoriesSelfHostedRunnersOrganizationRequest
    {
        /// <summary>
        /// IDs of repositories that can use repository-level self-hosted runners
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repository_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> SelectedRepositoryIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetSelectedRepositoriesSelfHostedRunnersOrganizationRequest" /> class.
        /// </summary>
        /// <param name="selectedRepositoryIds">
        /// IDs of repositories that can use repository-level self-hosted runners
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsSetSelectedRepositoriesSelfHostedRunnersOrganizationRequest(
            global::System.Collections.Generic.IList<int> selectedRepositoryIds)
        {
            this.SelectedRepositoryIds = selectedRepositoryIds ?? throw new global::System.ArgumentNullException(nameof(selectedRepositoryIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetSelectedRepositoriesSelfHostedRunnersOrganizationRequest" /> class.
        /// </summary>
        public ActionsSetSelectedRepositoriesSelfHostedRunnersOrganizationRequest()
        {
        }
    }
}