
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiInsightsGetSummaryStatsByActorActorType
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
    public static class ApiInsightsGetSummaryStatsByActorActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiInsightsGetSummaryStatsByActorActorType value)
        {
            return value switch
            {
                ApiInsightsGetSummaryStatsByActorActorType.Installations => "installations",
                ApiInsightsGetSummaryStatsByActorActorType.ClassicPats => "classic_pats",
                ApiInsightsGetSummaryStatsByActorActorType.FineGrainedPats => "fine_grained_pats",
                ApiInsightsGetSummaryStatsByActorActorType.OauthApps => "oauth_apps",
                ApiInsightsGetSummaryStatsByActorActorType.GithubAppsUserToServer => "github_apps_user_to_server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiInsightsGetSummaryStatsByActorActorType? ToEnum(string value)
        {
            return value switch
            {
                "installations" => ApiInsightsGetSummaryStatsByActorActorType.Installations,
                "classic_pats" => ApiInsightsGetSummaryStatsByActorActorType.ClassicPats,
                "fine_grained_pats" => ApiInsightsGetSummaryStatsByActorActorType.FineGrainedPats,
                "oauth_apps" => ApiInsightsGetSummaryStatsByActorActorType.OauthApps,
                "github_apps_user_to_server" => ApiInsightsGetSummaryStatsByActorActorType.GithubAppsUserToServer,
                _ => null,
            };
        }
    }
}