
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiInsightsSubjectStat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_type")]
        public string? SubjectType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_name")]
        public string? SubjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_id")]
        public long? SubjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_request_count")]
        public int? TotalRequestCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limited_request_count")]
        public int? RateLimitedRequestCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_rate_limited_timestamp")]
        public string? LastRateLimitedTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_request_timestamp")]
        public string? LastRequestTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiInsightsSubjectStat" /> class.
        /// </summary>
        /// <param name="subjectType"></param>
        /// <param name="subjectName"></param>
        /// <param name="subjectId"></param>
        /// <param name="totalRequestCount"></param>
        /// <param name="rateLimitedRequestCount"></param>
        /// <param name="lastRateLimitedTimestamp"></param>
        /// <param name="lastRequestTimestamp"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ApiInsightsSubjectStat(
            string? subjectType,
            string? subjectName,
            long? subjectId,
            int? totalRequestCount,
            int? rateLimitedRequestCount,
            string? lastRateLimitedTimestamp,
            string? lastRequestTimestamp)
        {
            this.SubjectType = subjectType;
            this.SubjectName = subjectName;
            this.SubjectId = subjectId;
            this.TotalRequestCount = totalRequestCount;
            this.RateLimitedRequestCount = rateLimitedRequestCount;
            this.LastRateLimitedTimestamp = lastRateLimitedTimestamp;
            this.LastRequestTimestamp = lastRequestTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiInsightsSubjectStat" /> class.
        /// </summary>
        public ApiInsightsSubjectStat()
        {
        }
    }
}