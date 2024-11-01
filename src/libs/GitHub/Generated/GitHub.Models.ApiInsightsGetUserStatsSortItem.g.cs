
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Default Value: total_request_count
    /// </summary>
    public enum ApiInsightsGetUserStatsSortItem
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
        SubjectName,
        /// <summary>
        /// 
        /// </summary>
        TotalRequestCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiInsightsGetUserStatsSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiInsightsGetUserStatsSortItem value)
        {
            return value switch
            {
                ApiInsightsGetUserStatsSortItem.LastRateLimitedTimestamp => "last_rate_limited_timestamp",
                ApiInsightsGetUserStatsSortItem.LastRequestTimestamp => "last_request_timestamp",
                ApiInsightsGetUserStatsSortItem.RateLimitedRequestCount => "rate_limited_request_count",
                ApiInsightsGetUserStatsSortItem.SubjectName => "subject_name",
                ApiInsightsGetUserStatsSortItem.TotalRequestCount => "total_request_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiInsightsGetUserStatsSortItem? ToEnum(string value)
        {
            return value switch
            {
                "last_rate_limited_timestamp" => ApiInsightsGetUserStatsSortItem.LastRateLimitedTimestamp,
                "last_request_timestamp" => ApiInsightsGetUserStatsSortItem.LastRequestTimestamp,
                "rate_limited_request_count" => ApiInsightsGetUserStatsSortItem.RateLimitedRequestCount,
                "subject_name" => ApiInsightsGetUserStatsSortItem.SubjectName,
                "total_request_count" => ApiInsightsGetUserStatsSortItem.TotalRequestCount,
                _ => null,
            };
        }
    }
}