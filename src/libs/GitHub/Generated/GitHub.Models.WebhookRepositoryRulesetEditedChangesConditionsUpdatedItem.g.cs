
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesConditionsUpdatedItem
    {
        /// <summary>
        /// Parameters for a repository ruleset ref name condition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public global::GitHub.RepositoryRulesetConditions? Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        public global::GitHub.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges? Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesConditionsUpdatedItem" /> class.
        /// </summary>
        /// <param name="condition">
        /// Parameters for a repository ruleset ref name condition
        /// </param>
        /// <param name="changes"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedItem(
            global::GitHub.RepositoryRulesetConditions? condition,
            global::GitHub.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges? changes)
        {
            this.Condition = condition;
            this.Changes = changes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesConditionsUpdatedItem" /> class.
        /// </summary>
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedItem()
        {
        }
    }
}