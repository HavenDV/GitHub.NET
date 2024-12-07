
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
        Installation,
        /// <summary>
        /// 
        /// </summary>
        ClassicPat,
        /// <summary>
        /// 
        /// </summary>
        FineGrainedPat,
        /// <summary>
        /// 
        /// </summary>
        OauthApp,
        /// <summary>
        /// 
        /// </summary>
        GithubAppUserToServer,
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
                ApiInsightsGetRouteStatsByActorActorType.Installation => "installation",
                ApiInsightsGetRouteStatsByActorActorType.ClassicPat => "classic_pat",
                ApiInsightsGetRouteStatsByActorActorType.FineGrainedPat => "fine_grained_pat",
                ApiInsightsGetRouteStatsByActorActorType.OauthApp => "oauth_app",
                ApiInsightsGetRouteStatsByActorActorType.GithubAppUserToServer => "github_app_user_to_server",
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
                "installation" => ApiInsightsGetRouteStatsByActorActorType.Installation,
                "classic_pat" => ApiInsightsGetRouteStatsByActorActorType.ClassicPat,
                "fine_grained_pat" => ApiInsightsGetRouteStatsByActorActorType.FineGrainedPat,
                "oauth_app" => ApiInsightsGetRouteStatsByActorActorType.OauthApp,
                "github_app_user_to_server" => ApiInsightsGetRouteStatsByActorActorType.GithubAppUserToServer,
                _ => null,
            };
        }
    }
}