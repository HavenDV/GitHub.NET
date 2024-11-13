
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiInsightsRouteStat
    {
        /// <summary>
        /// The HTTP method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_method")]
        public string? HttpMethod { get; set; }

        /// <summary>
        /// The API path's route template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_route")]
        public string? ApiRoute { get; set; }

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
        /// Initializes a new instance of the <see cref="ApiInsightsRouteStat" /> class.
        /// </summary>
        /// <param name="httpMethod">
        /// The HTTP method
        /// </param>
        /// <param name="apiRoute">
        /// The API path's route template
        /// </param>
        /// <param name="totalRequestCount">
        /// The total number of requests within the queried time period
        /// </param>
        /// <param name="rateLimitedRequestCount">
        /// The total number of requests that were rate limited within the queried time period
        /// </param>
        /// <param name="lastRateLimitedTimestamp"></param>
        /// <param name="lastRequestTimestamp"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ApiInsightsRouteStat(
            string? httpMethod,
            string? apiRoute,
            long? totalRequestCount,
            long? rateLimitedRequestCount,
            string? lastRateLimitedTimestamp,
            string? lastRequestTimestamp)
        {
            this.HttpMethod = httpMethod;
            this.ApiRoute = apiRoute;
            this.TotalRequestCount = totalRequestCount;
            this.RateLimitedRequestCount = rateLimitedRequestCount;
            this.LastRateLimitedTimestamp = lastRateLimitedTimestamp;
            this.LastRequestTimestamp = lastRequestTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiInsightsRouteStat" /> class.
        /// </summary>
        public ApiInsightsRouteStat()
        {
        }
    }
}