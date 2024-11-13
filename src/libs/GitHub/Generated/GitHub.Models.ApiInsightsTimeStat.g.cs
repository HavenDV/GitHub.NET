
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiInsightsTimeStat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_request_count")]
        public long? TotalRequestCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limited_request_count")]
        public long? RateLimitedRequestCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiInsightsTimeStat" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="totalRequestCount"></param>
        /// <param name="rateLimitedRequestCount"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ApiInsightsTimeStat(
            string? timestamp,
            long? totalRequestCount,
            long? rateLimitedRequestCount)
        {
            this.Timestamp = timestamp;
            this.TotalRequestCount = totalRequestCount;
            this.RateLimitedRequestCount = rateLimitedRequestCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiInsightsTimeStat" /> class.
        /// </summary>
        public ApiInsightsTimeStat()
        {
        }
    }
}