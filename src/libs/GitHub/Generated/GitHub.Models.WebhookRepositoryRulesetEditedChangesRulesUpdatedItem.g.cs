
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesRulesUpdatedItem
    {
        /// <summary>
        /// A repository rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RepositoryRuleJsonConverter))]
        public global::GitHub.RepositoryRule? Rule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        public global::GitHub.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges? Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}