
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Default Value: total_request_count
    /// </summary>
    public enum ApiInsightsGetSubjectStatsSortItem
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
    public static class ApiInsightsGetSubjectStatsSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiInsightsGetSubjectStatsSortItem value)
        {
            return value switch
            {
                ApiInsightsGetSubjectStatsSortItem.LastRateLimitedTimestamp => "last_rate_limited_timestamp",
                ApiInsightsGetSubjectStatsSortItem.LastRequestTimestamp => "last_request_timestamp",
                ApiInsightsGetSubjectStatsSortItem.RateLimitedRequestCount => "rate_limited_request_count",
                ApiInsightsGetSubjectStatsSortItem.SubjectName => "subject_name",
                ApiInsightsGetSubjectStatsSortItem.TotalRequestCount => "total_request_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiInsightsGetSubjectStatsSortItem? ToEnum(string value)
        {
            return value switch
            {
                "last_rate_limited_timestamp" => ApiInsightsGetSubjectStatsSortItem.LastRateLimitedTimestamp,
                "last_request_timestamp" => ApiInsightsGetSubjectStatsSortItem.LastRequestTimestamp,
                "rate_limited_request_count" => ApiInsightsGetSubjectStatsSortItem.RateLimitedRequestCount,
                "subject_name" => ApiInsightsGetSubjectStatsSortItem.SubjectName,
                "total_request_count" => ApiInsightsGetSubjectStatsSortItem.TotalRequestCount,
                _ => null,
            };
        }
    }
}