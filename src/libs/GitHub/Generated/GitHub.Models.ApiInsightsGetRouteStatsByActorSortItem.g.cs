
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Default Value: total_request_count
    /// </summary>
    public enum ApiInsightsGetRouteStatsByActorSortItem
    {
        /// <summary>
        /// 
        /// </summary>
        LastRateLimitedTimestamp,
        /// <summary>
        /// 
        /// </summary>
        LastRequestTimestamp,
        /// <summary>
        /// 
        /// </summary>
        RateLimitedRequestCount,
        /// <summary>
        /// 
        /// </summary>
        HttpMethod,
        /// <summary>
        /// 
        /// </summary>
        ApiRoute,
        /// <summary>
        /// 
        /// </summary>
        TotalRequestCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiInsightsGetRouteStatsByActorSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiInsightsGetRouteStatsByActorSortItem value)
        {
            return value switch
            {
                ApiInsightsGetRouteStatsByActorSortItem.LastRateLimitedTimestamp => "last_rate_limited_timestamp",
                ApiInsightsGetRouteStatsByActorSortItem.LastRequestTimestamp => "last_request_timestamp",
                ApiInsightsGetRouteStatsByActorSortItem.RateLimitedRequestCount => "rate_limited_request_count",
                ApiInsightsGetRouteStatsByActorSortItem.HttpMethod => "http_method",
                ApiInsightsGetRouteStatsByActorSortItem.ApiRoute => "api_route",
                ApiInsightsGetRouteStatsByActorSortItem.TotalRequestCount => "total_request_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiInsightsGetRouteStatsByActorSortItem? ToEnum(string value)
        {
            return value switch
            {
                "last_rate_limited_timestamp" => ApiInsightsGetRouteStatsByActorSortItem.LastRateLimitedTimestamp,
                "last_request_timestamp" => ApiInsightsGetRouteStatsByActorSortItem.LastRequestTimestamp,
                "rate_limited_request_count" => ApiInsightsGetRouteStatsByActorSortItem.RateLimitedRequestCount,
                "http_method" => ApiInsightsGetRouteStatsByActorSortItem.HttpMethod,
                "api_route" => ApiInsightsGetRouteStatsByActorSortItem.ApiRoute,
                "total_request_count" => ApiInsightsGetRouteStatsByActorSortItem.TotalRequestCount,
                _ => null,
            };
        }
    }
}