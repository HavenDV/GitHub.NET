
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ApiInsightsGetUserStatsDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiInsightsGetUserStatsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiInsightsGetUserStatsDirection value)
        {
            return value switch
            {
                ApiInsightsGetUserStatsDirection.Asc => "asc",
                ApiInsightsGetUserStatsDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiInsightsGetUserStatsDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ApiInsightsGetUserStatsDirection.Asc,
                "desc" => ApiInsightsGetUserStatsDirection.Desc,
                _ => null,
            };
        }
    }
}