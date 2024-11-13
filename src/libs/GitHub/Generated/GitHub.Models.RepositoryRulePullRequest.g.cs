
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Require all commits be made to a non-target branch and submitted via a pull request before they can be merged.
    /// </summary>
    public sealed partial class RepositoryRulePullRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.RepositoryRulePullRequestTypeJsonConverter))]
        public global::GitHub.RepositoryRulePullRequestType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::GitHub.RepositoryRulePullRequestParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulePullRequest" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRulePullRequest(
            global::GitHub.RepositoryRulePullRequestType type,
            global::GitHub.RepositoryRulePullRequestParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulePullRequest" /> class.
        /// </summary>
        public RepositoryRulePullRequest()
        {
        }
    }
}