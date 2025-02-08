
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Parameters for a repository ID condition
    /// </summary>
    public sealed partial class RepositoryRulesetConditionsRepositoryIdTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.RepositoryRulesetConditionsRepositoryIdTargetRepositoryId RepositoryId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditionsRepositoryIdTarget" /> class.
        /// </summary>
        /// <param name="repositoryId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRulesetConditionsRepositoryIdTarget(
            global::GitHub.RepositoryRulesetConditionsRepositoryIdTargetRepositoryId repositoryId)
        {
            this.RepositoryId = repositoryId ?? throw new global::System.ArgumentNullException(nameof(repositoryId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditionsRepositoryIdTarget" /> class.
        /// </summary>
        public RepositoryRulesetConditionsRepositoryIdTarget()
        {
        }
    }
}