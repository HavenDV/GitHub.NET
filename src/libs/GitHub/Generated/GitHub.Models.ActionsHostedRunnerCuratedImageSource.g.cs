
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The image provider.
    /// </summary>
    public enum ActionsHostedRunnerCuratedImageSource
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
    public static class ActionsHostedRunnerCuratedImageSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsHostedRunnerCuratedImageSource value)
        {
            return value switch
            {
                ActionsHostedRunnerCuratedImageSource.Github => "github",
                ActionsHostedRunnerCuratedImageSource.Partner => "partner",
                ActionsHostedRunnerCuratedImageSource.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsHostedRunnerCuratedImageSource? ToEnum(string value)
        {
            return value switch
            {
                "github" => ActionsHostedRunnerCuratedImageSource.Github,
                "partner" => ActionsHostedRunnerCuratedImageSource.Partner,
                "custom" => ActionsHostedRunnerCuratedImageSource.Custom,
                _ => null,
            };
        }
    }
}