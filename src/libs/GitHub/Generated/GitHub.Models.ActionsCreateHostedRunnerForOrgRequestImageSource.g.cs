
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The source of the runner image.
    /// </summary>
    public enum ActionsCreateHostedRunnerForOrgRequestImageSource
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Partner,
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsCreateHostedRunnerForOrgRequestImageSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsCreateHostedRunnerForOrgRequestImageSource value)
        {
            return value switch
            {
                ActionsCreateHostedRunnerForOrgRequestImageSource.Github => "github",
                ActionsCreateHostedRunnerForOrgRequestImageSource.Partner => "partner",
                ActionsCreateHostedRunnerForOrgRequestImageSource.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsCreateHostedRunnerForOrgRequestImageSource? ToEnum(string value)
        {
            return value switch
            {
                "github" => ActionsCreateHostedRunnerForOrgRequestImageSource.Github,
                "partner" => ActionsCreateHostedRunnerForOrgRequestImageSource.Partner,
                "custom" => ActionsCreateHostedRunnerForOrgRequestImageSource.Custom,
                _ => null,
            };
        }
    }
}