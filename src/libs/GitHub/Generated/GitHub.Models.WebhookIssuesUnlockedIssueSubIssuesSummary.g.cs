
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookIssuesUnlockedIssueSubIssuesSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Completed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent_completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PercentCompleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesUnlockedIssueSubIssuesSummary" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="completed"></param>
        /// <param name="percentCompleted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookIssuesUnlockedIssueSubIssuesSummary(
            int total,
            int completed,
            int percentCompleted)
        {
            this.Total = total;
            this.Completed = completed;
            this.PercentCompleted = percentCompleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesUnlockedIssueSubIssuesSummary" /> class.
        /// </summary>
        public WebhookIssuesUnlockedIssueSubIssuesSummary()
        {
        }
    }
}