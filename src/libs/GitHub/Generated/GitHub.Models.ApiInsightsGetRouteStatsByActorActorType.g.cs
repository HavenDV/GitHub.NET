
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiInsightsGetRouteStatsByActorActorType
    {
        /// <summary>
        /// 
        /// </summary>
        Installations,
        /// <summary>
        /// 
        /// </summary>
        ClassicPats,
        /// <summary>
        /// 
        /// </summary>
        FineGrainedPats,
        /// <summary>
        /// 
        /// </summary>
        OauthApps,
        /// <summary>
        /// 
        /// </summary>
        GithubAppsUserToServer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiInsightsGetRouteStatsByActorActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiInsightsGetRouteStatsByActorActorType value)
        {
            return value switch
            {
                ApiInsightsGetRouteStatsByActorActorType.Installations => "installations",
                ApiInsightsGetRouteStatsByActorActorType.ClassicPats => "classic_pats",
                ApiInsightsGetRouteStatsByActorActorType.FineGrainedPats => "fine_grained_pats",
                ApiInsightsGetRouteStatsByActorActorType.OauthApps => "oauth_apps",
                ApiInsightsGetRouteStatsByActorActorType.GithubAppsUserToServer => "github_apps_user_to_server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiInsightsGetRouteStatsByActorActorType? ToEnum(string value)
        {
            return value switch
            {
                "installations" => ApiInsightsGetRouteStatsByActorActorType.Installations,
                "classic_pats" => ApiInsightsGetRouteStatsByActorActorType.ClassicPats,
                "fine_grained_pats" => ApiInsightsGetRouteStatsByActorActorType.FineGrainedPats,
                "oauth_apps" => ApiInsightsGetRouteStatsByActorActorType.OauthApps,
                "github_apps_user_to_server" => ApiInsightsGetRouteStatsByActorActorType.GithubAppsUserToServer,
                _ => null,
            };
        }
    }
}