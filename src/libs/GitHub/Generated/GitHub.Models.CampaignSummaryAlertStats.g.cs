
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CampaignSummaryAlertStats
    {
        /// <summary>
        /// The number of open alerts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("open_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OpenCount { get; set; }

        /// <summary>
        /// The number of closed alerts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClosedCount { get; set; }

        /// <summary>
        /// The number of in-progress alerts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_progress_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InProgressCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSummaryAlertStats" /> class.
        /// </summary>
        /// <param name="openCount">
        /// The number of open alerts
        /// </param>
        /// <param name="closedCount">
        /// The number of closed alerts
        /// </param>
        /// <param name="inProgressCount">
        /// The number of in-progress alerts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignSummaryAlertStats(
            int openCount,
            int closedCount,
            int inProgressCount)
        {
            this.OpenCount = openCount;
            this.ClosedCount = closedCount;
            this.InProgressCount = inProgressCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSummaryAlertStats" /> class.
        /// </summary>
        public CampaignSummaryAlertStats()
        {
        }
    }
}