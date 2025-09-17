
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Request Copilot code review for new pull requests automatically if the author has access to Copilot code review.
    /// </summary>
    public sealed partial class RepositoryRuleCopilotCodeReview
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.RepositoryRuleCopilotCodeReviewTypeJsonConverter))]
        public global::GitHub.RepositoryRuleCopilotCodeReviewType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::GitHub.RepositoryRuleCopilotCodeReviewParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCopilotCodeReview" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleCopilotCodeReview(
            global::GitHub.RepositoryRuleCopilotCodeReviewType type,
            global::GitHub.RepositoryRuleCopilotCodeReviewParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCopilotCodeReview" /> class.
        /// </summary>
        public RepositoryRuleCopilotCodeReview()
        {
        }
    }
}