
#nullable enable

namespace GitHub
{
    /// <summary>
    /// What type of content was scanned
    /// </summary>
    public enum WebhookSecretScanningScanCompletedSource
    {
        /// <summary>
        /// 
        /// </summary>
        Git,
        /// <summary>
        /// 
        /// </summary>
        Issues,
        /// <summary>
        /// 
        /// </summary>
        PullRequests,
        /// <summary>
        /// 
        /// </summary>
        Discussions,
        /// <summary>
        /// 
        /// </summary>
        Wiki,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningScanCompletedSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningScanCompletedSource value)
        {
            return value switch
            {
                WebhookSecretScanningScanCompletedSource.Git => "git",
                WebhookSecretScanningScanCompletedSource.Issues => "issues",
                WebhookSecretScanningScanCompletedSource.PullRequests => "pull-requests",
                WebhookSecretScanningScanCompletedSource.Discussions => "discussions",
                WebhookSecretScanningScanCompletedSource.Wiki => "wiki",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningScanCompletedSource? ToEnum(string value)
        {
            return value switch
            {
                "git" => WebhookSecretScanningScanCompletedSource.Git,
                "issues" => WebhookSecretScanningScanCompletedSource.Issues,
                "pull-requests" => WebhookSecretScanningScanCompletedSource.PullRequests,
                "discussions" => WebhookSecretScanningScanCompletedSource.Discussions,
                "wiki" => WebhookSecretScanningScanCompletedSource.Wiki,
                _ => null,
            };
        }
    }
}