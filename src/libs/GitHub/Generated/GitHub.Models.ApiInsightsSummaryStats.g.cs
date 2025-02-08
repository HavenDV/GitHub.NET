
#nullable enable

namespace GitHub
{
    /// <summary>
    /// API Insights usage summary stats for an organization
    /// </summary>
    public sealed partial class ApiInsightsSummaryStats
    {
        /// <summary>
        /// The total number of requests within the queried time period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_request_count")]
        public long? TotalRequestCount { get; set; }

        /// <summary>
        /// The total number of requests that were rate limited within the queried time period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limited_request_count")]
        public long? RateLimitedRequestCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiInsightsSummaryStats" /> class.
        /// </summary>
        /// <param name="totalRequestCount">
        /// The total number of requests within the queried time period
        /// </param>
        /// <param name="rateLimitedRequestCount">
        /// The total number of requests that were rate limited within the queried time period
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiInsightsSummaryStats(
            long? totalRequestCount,
            long? rateLimitedRequestCount)
        {
            this.TotalRequestCount = totalRequestCount;
            this.RateLimitedRequestCount = rateLimitedRequestCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiInsightsSummaryStats" /> class.
        /// </summary>
        public ApiInsightsSummaryStats()
        {
        }
    }
}