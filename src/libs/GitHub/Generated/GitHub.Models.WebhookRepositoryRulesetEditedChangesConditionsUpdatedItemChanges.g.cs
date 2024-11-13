
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition_type")]
        public global::GitHub.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesConditionType? ConditionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::GitHub.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesTarget? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::GitHub.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesInclude? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::GitHub.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesExclude? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges" /> class.
        /// </summary>
        /// <param name="conditionType"></param>
        /// <param name="target"></param>
        /// <param name="include"></param>
        /// <param name="exclude"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges(
            global::GitHub.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesConditionType? conditionType,
            global::GitHub.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesTarget? target,
            global::GitHub.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesInclude? include,
            global::GitHub.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesExclude? exclude)
        {
            this.ConditionType = conditionType;
            this.Target = target;
            this.Include = include;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges" /> class.
        /// </summary>
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges()
        {
        }
    }
}