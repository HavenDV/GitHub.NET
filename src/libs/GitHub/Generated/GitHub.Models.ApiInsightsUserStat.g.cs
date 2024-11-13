
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiInsightsUserStat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_type")]
        public string? ActorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_name")]
        public string? ActorName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_id")]
        public long? ActorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_id")]
        public long? IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_application_id")]
        public long? OauthApplicationId { get; set; }

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
        /// Initializes a new instance of the <see cref="ApiInsightsUserStat" /> class.
        /// </summary>
        /// <param name="actorType"></param>
        /// <param name="actorName"></param>
        /// <param name="actorId"></param>
        /// <param name="integrationId"></param>
        /// <param name="oauthApplicationId"></param>
        /// <param name="totalRequestCount"></param>
        /// <param name="rateLimitedRequestCount"></param>
        /// <param name="lastRateLimitedTimestamp"></param>
        /// <param name="lastRequestTimestamp"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ApiInsightsUserStat(
            string? actorType,
            string? actorName,
            long? actorId,
            long? integrationId,
            long? oauthApplicationId,
            int? totalRequestCount,
            int? rateLimitedRequestCount,
            string? lastRateLimitedTimestamp,
            string? lastRequestTimestamp)
        {
            this.ActorType = actorType;
            this.ActorName = actorName;
            this.ActorId = actorId;
            this.IntegrationId = integrationId;
            this.OauthApplicationId = oauthApplicationId;
            this.TotalRequestCount = totalRequestCount;
            this.RateLimitedRequestCount = rateLimitedRequestCount;
            this.LastRateLimitedTimestamp = lastRateLimitedTimestamp;
            this.LastRequestTimestamp = lastRequestTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiInsightsUserStat" /> class.
        /// </summary>
        public ApiInsightsUserStat()
        {
        }
    }
}