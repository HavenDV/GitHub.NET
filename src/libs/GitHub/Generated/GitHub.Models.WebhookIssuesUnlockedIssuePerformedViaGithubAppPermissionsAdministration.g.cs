
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsAdministration
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsAdministrationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsAdministration value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsAdministration.Read => "read",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsAdministration.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsAdministration? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsAdministration.Read,
                "write" => WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsAdministration.Write,
                _ => null,
            };
        }
    }
}