
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
    public static class ApiInsightsGetSummaryStatsByActorActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiInsightsGetSummaryStatsByActorActorType value)
        {
            return value switch
            {
                ApiInsightsGetSummaryStatsByActorActorType.Installation => "installation",
                ApiInsightsGetSummaryStatsByActorActorType.ClassicPat => "classic_pat",
                ApiInsightsGetSummaryStatsByActorActorType.FineGrainedPat => "fine_grained_pat",
                ApiInsightsGetSummaryStatsByActorActorType.OauthApp => "oauth_app",
                ApiInsightsGetSummaryStatsByActorActorType.GithubAppUserToServer => "github_app_user_to_server",
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
                "installation" => ApiInsightsGetSummaryStatsByActorActorType.Installation,
                "classic_pat" => ApiInsightsGetSummaryStatsByActorActorType.ClassicPat,
                "fine_grained_pat" => ApiInsightsGetSummaryStatsByActorActorType.FineGrainedPat,
                "oauth_app" => ApiInsightsGetSummaryStatsByActorActorType.OauthApp,
                "github_app_user_to_server" => ApiInsightsGetSummaryStatsByActorActorType.GithubAppUserToServer,
                _ => null,
            };
        }
    }
}