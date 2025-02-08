
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesAddSubIssueRequest
    {
        /// <summary>
        /// The id of the sub-issue to add. The sub-issue must belong to the same repository as the parent issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_issue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SubIssueId { get; set; }

        /// <summary>
        /// Option that, when true, instructs the operation to replace the sub-issues current parent issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace_parent")]
        public bool? ReplaceParent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddSubIssueRequest" /> class.
        /// </summary>
        /// <param name="subIssueId">
        /// The id of the sub-issue to add. The sub-issue must belong to the same repository as the parent issue
        /// </param>
        /// <param name="replaceParent">
        /// Option that, when true, instructs the operation to replace the sub-issues current parent issue
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesAddSubIssueRequest(
            int subIssueId,
            bool? replaceParent)
        {
            this.SubIssueId = subIssueId;
            this.ReplaceParent = replaceParent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddSubIssueRequest" /> class.
        /// </summary>
        public IssuesAddSubIssueRequest()
        {
        }
    }
}