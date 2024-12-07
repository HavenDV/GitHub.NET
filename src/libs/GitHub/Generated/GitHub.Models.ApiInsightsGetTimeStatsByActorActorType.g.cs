
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
    public static class ApiInsightsGetTimeStatsByActorActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiInsightsGetTimeStatsByActorActorType value)
        {
            return value switch
            {
                ApiInsightsGetTimeStatsByActorActorType.Installation => "installation",
                ApiInsightsGetTimeStatsByActorActorType.ClassicPat => "classic_pat",
                ApiInsightsGetTimeStatsByActorActorType.FineGrainedPat => "fine_grained_pat",
                ApiInsightsGetTimeStatsByActorActorType.OauthApp => "oauth_app",
                ApiInsightsGetTimeStatsByActorActorType.GithubAppUserToServer => "github_app_user_to_server",
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
                "installation" => ApiInsightsGetTimeStatsByActorActorType.Installation,
                "classic_pat" => ApiInsightsGetTimeStatsByActorActorType.ClassicPat,
                "fine_grained_pat" => ApiInsightsGetTimeStatsByActorActorType.FineGrainedPat,
                "oauth_app" => ApiInsightsGetTimeStatsByActorActorType.OauthApp,
                "github_app_user_to_server" => ApiInsightsGetTimeStatsByActorActorType.GithubAppUserToServer,
                _ => null,
            };
        }
    }
}