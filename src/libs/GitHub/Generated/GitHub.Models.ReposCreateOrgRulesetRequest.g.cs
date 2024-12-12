
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateOrgRulesetRequest
    {
        /// <summary>
        /// The name of the ruleset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The target of the ruleset<br/>
        /// Default Value: branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.ReposCreateOrgRulesetRequestTargetJsonConverter))]
        public global::GitHub.ReposCreateOrgRulesetRequestTarget? Target { get; set; }

        /// <summary>
        /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.RepositoryRuleEnforcementJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.RepositoryRuleEnforcement Enforcement { get; set; }

        /// <summary>
        /// The actors that can bypass the rules in this ruleset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bypass_actors")]
        public global::System.Collections.Generic.IList<global::GitHub.RepositoryRulesetBypassActor>? BypassActors { get; set; }

        /// <summary>
        /// Conditions for an organization ruleset.<br/>
        /// The branch and tag rulesets conditions object should contain both `repository_name` and `ref_name` properties, or both `repository_id` and `ref_name` properties, or both `repository_property` and `ref_name` properties.<br/>
        /// The push rulesets conditions object does not require the `ref_name` property.<br/>
        /// For repository policy rulesets, the conditions object should only contain the `repository_name`, the `repository_id`, or the `repository_property`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OrgRulesetConditionsJsonConverter))]
        public global::GitHub.OrgRulesetConditions? Conditions { get; set; }

        /// <summary>
        /// An array of rules within the ruleset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::GitHub.RepositoryRule>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateOrgRulesetRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the ruleset.
        /// </param>
        /// <param name="target">
        /// The target of the ruleset<br/>
        /// Default Value: branch
        /// </param>
        /// <param name="enforcement">
        /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
        /// </param>
        /// <param name="bypassActors">
        /// The actors that can bypass the rules in this ruleset
        /// </param>
        /// <param name="conditions">
        /// Conditions for an organization ruleset.<br/>
        /// The branch and tag rulesets conditions object should contain both `repository_name` and `ref_name` properties, or both `repository_id` and `ref_name` properties, or both `repository_property` and `ref_name` properties.<br/>
        /// The push rulesets conditions object does not require the `ref_name` property.<br/>
        /// For repository policy rulesets, the conditions object should only contain the `repository_name`, the `repository_id`, or the `repository_property`.
        /// </param>
        /// <param name="rules">
        /// An array of rules within the ruleset.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposCreateOrgRulesetRequest(
            string name,
            global::GitHub.RepositoryRuleEnforcement enforcement,
            global::GitHub.ReposCreateOrgRulesetRequestTarget? target,
            global::System.Collections.Generic.IList<global::GitHub.RepositoryRulesetBypassActor>? bypassActors,
            global::GitHub.OrgRulesetConditions? conditions,
            global::System.Collections.Generic.IList<global::GitHub.RepositoryRule>? rules)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Enforcement = enforcement;
            this.Target = target;
            this.BypassActors = bypassActors;
            this.Conditions = conditions;
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateOrgRulesetRequest" /> class.
        /// </summary>
        public ReposCreateOrgRulesetRequest()
        {
        }
    }
}