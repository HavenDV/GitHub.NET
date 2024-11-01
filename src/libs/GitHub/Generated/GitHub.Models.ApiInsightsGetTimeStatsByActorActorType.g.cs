
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiInsightsGetTimeStatsByActorActorType
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
    public static class ApiInsightsGetTimeStatsByActorActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiInsightsGetTimeStatsByActorActorType value)
        {
            return value switch
            {
                ApiInsightsGetTimeStatsByActorActorType.Installations => "installations",
                ApiInsightsGetTimeStatsByActorActorType.ClassicPats => "classic_pats",
                ApiInsightsGetTimeStatsByActorActorType.FineGrainedPats => "fine_grained_pats",
                ApiInsightsGetTimeStatsByActorActorType.OauthApps => "oauth_apps",
                ApiInsightsGetTimeStatsByActorActorType.GithubAppsUserToServer => "github_apps_user_to_server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiInsightsGetTimeStatsByActorActorType? ToEnum(string value)
        {
            return value switch
            {
                "installations" => ApiInsightsGetTimeStatsByActorActorType.Installations,
                "classic_pats" => ApiInsightsGetTimeStatsByActorActorType.ClassicPats,
                "fine_grained_pats" => ApiInsightsGetTimeStatsByActorActorType.FineGrainedPats,
                "oauth_apps" => ApiInsightsGetTimeStatsByActorActorType.OauthApps,
                "github_apps_user_to_server" => ApiInsightsGetTimeStatsByActorActorType.GithubAppsUserToServer,
                _ => null,
            };
        }
    }
}