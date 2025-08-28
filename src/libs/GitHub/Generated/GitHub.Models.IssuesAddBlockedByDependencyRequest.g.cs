
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesAddBlockedByDependencyRequest
    {
        /// <summary>
        /// The id of the issue that blocks the current issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IssueId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddBlockedByDependencyRequest" /> class.
        /// </summary>
        /// <param name="issueId">
        /// The id of the issue that blocks the current issue
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesAddBlockedByDependencyRequest(
            int issueId)
        {
            this.IssueId = issueId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddBlockedByDependencyRequest" /> class.
        /// </summary>
        public IssuesAddBlockedByDependencyRequest()
        {
        }
    }
}