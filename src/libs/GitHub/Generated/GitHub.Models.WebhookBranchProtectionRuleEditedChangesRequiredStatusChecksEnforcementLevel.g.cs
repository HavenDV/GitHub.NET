
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFromJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevel" /> class.
        /// </summary>
        /// <param name="from"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevel(
            global::GitHub.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom from)
        {
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevel" /> class.
        /// </summary>
        public WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevel()
        {
        }
    }
}