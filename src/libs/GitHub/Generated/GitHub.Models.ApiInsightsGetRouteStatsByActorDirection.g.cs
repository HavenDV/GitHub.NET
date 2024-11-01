
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ApiInsightsGetRouteStatsByActorDirection
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
    public static class ApiInsightsGetRouteStatsByActorDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiInsightsGetRouteStatsByActorDirection value)
        {
            return value switch
            {
                ApiInsightsGetRouteStatsByActorDirection.Asc => "asc",
                ApiInsightsGetRouteStatsByActorDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiInsightsGetRouteStatsByActorDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ApiInsightsGetRouteStatsByActorDirection.Asc,
                "desc" => ApiInsightsGetRouteStatsByActorDirection.Desc,
                _ => null,
            };
        }
    }
}