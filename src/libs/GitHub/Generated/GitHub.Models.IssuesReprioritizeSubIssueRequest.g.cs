
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesReprioritizeSubIssueRequest
    {
        /// <summary>
        /// The id of the sub-issue to reprioritize
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_issue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SubIssueId { get; set; }

        /// <summary>
        /// The id of the sub-issue to be prioritized after (either positional argument after OR before should be specified).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after_id")]
        public int? AfterId { get; set; }

        /// <summary>
        /// The id of the sub-issue to be prioritized before (either positional argument after OR before should be specified).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before_id")]
        public int? BeforeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesReprioritizeSubIssueRequest" /> class.
        /// </summary>
        /// <param name="subIssueId">
        /// The id of the sub-issue to reprioritize
        /// </param>
        /// <param name="afterId">
        /// The id of the sub-issue to be prioritized after (either positional argument after OR before should be specified).
        /// </param>
        /// <param name="beforeId">
        /// The id of the sub-issue to be prioritized before (either positional argument after OR before should be specified).
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public IssuesReprioritizeSubIssueRequest(
            int subIssueId,
            int? afterId,
            int? beforeId)
        {
            this.SubIssueId = subIssueId;
            this.AfterId = afterId;
            this.BeforeId = beforeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesReprioritizeSubIssueRequest" /> class.
        /// </summary>
        public IssuesReprioritizeSubIssueRequest()
        {
        }
    }
}