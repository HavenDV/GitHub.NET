
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleBranchNamePatternParameters
    {
        /// <summary>
        /// How this rule will appear to users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// If true, the rule will fail if the pattern matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negate")]
        public bool Negate { get; set; }

        /// <summary>
        /// The operator to use for matching.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RepositoryRuleBranchNamePatternParametersOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.RepositoryRuleBranchNamePatternParametersOperator Operator { get; set; }

        /// <summary>
        /// The pattern to match with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}