
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::GitHub.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesConfiguration? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_type")]
        public global::GitHub.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesRuleType? RuleType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public global::GitHub.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesPattern? Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges" /> class.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="ruleType"></param>
        /// <param name="pattern"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges(
            global::GitHub.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesConfiguration? configuration,
            global::GitHub.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesRuleType? ruleType,
            global::GitHub.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesPattern? pattern)
        {
            this.Configuration = configuration;
            this.RuleType = ruleType;
            this.Pattern = pattern;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges" /> class.
        /// </summary>
        public WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges()
        {
        }
    }
}