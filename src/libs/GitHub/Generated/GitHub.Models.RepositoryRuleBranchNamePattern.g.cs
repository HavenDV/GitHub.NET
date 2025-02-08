
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Parameters to be used for the branch_name_pattern rule
    /// </summary>
    public sealed partial class RepositoryRuleBranchNamePattern
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.RepositoryRuleBranchNamePatternTypeJsonConverter))]
        public global::GitHub.RepositoryRuleBranchNamePatternType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::GitHub.RepositoryRuleBranchNamePatternParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleBranchNamePattern" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleBranchNamePattern(
            global::GitHub.RepositoryRuleBranchNamePatternType type,
            global::GitHub.RepositoryRuleBranchNamePatternParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleBranchNamePattern" /> class.
        /// </summary>
        public RepositoryRuleBranchNamePattern()
        {
        }
    }
}