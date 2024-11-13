
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Parameters for a repository ruleset ref name condition
    /// </summary>
    public sealed partial class RepositoryRulesetConditions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref_name")]
        public global::GitHub.RepositoryRulesetConditionsRefName? RefName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditions" /> class.
        /// </summary>
        /// <param name="refName"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRulesetConditions(
            global::GitHub.RepositoryRulesetConditionsRefName? refName)
        {
            this.RefName = refName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditions" /> class.
        /// </summary>
        public RepositoryRulesetConditions()
        {
        }
    }
}