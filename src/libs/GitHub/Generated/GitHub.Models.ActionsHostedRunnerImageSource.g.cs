
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The image provider.
    /// </summary>
    public enum ActionsHostedRunnerImageSource
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
    public static class ActionsHostedRunnerImageSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsHostedRunnerImageSource value)
        {
            return value switch
            {
                ActionsHostedRunnerImageSource.Github => "github",
                ActionsHostedRunnerImageSource.Partner => "partner",
                ActionsHostedRunnerImageSource.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsHostedRunnerImageSource? ToEnum(string value)
        {
            return value switch
            {
                "github" => ActionsHostedRunnerImageSource.Github,
                "partner" => ActionsHostedRunnerImageSource.Partner,
                "custom" => ActionsHostedRunnerImageSource.Custom,
                _ => null,
            };
        }
    }
}