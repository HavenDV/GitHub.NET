
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesRemoveSubIssueRequest
    {
        /// <summary>
        /// The id of the sub-issue to remove
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_issue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SubIssueId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesRemoveSubIssueRequest" /> class.
        /// </summary>
        /// <param name="subIssueId">
        /// The id of the sub-issue to remove
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public IssuesRemoveSubIssueRequest(
            int subIssueId)
        {
            this.SubIssueId = subIssueId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesRemoveSubIssueRequest" /> class.
        /// </summary>
        public IssuesRemoveSubIssueRequest()
        {
        }
    }
}