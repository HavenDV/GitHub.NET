
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The image provider.
    /// </summary>
    public enum NullableActionsHostedRunnerPoolImageSource
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
    public static class NullableActionsHostedRunnerPoolImageSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableActionsHostedRunnerPoolImageSource value)
        {
            return value switch
            {
                NullableActionsHostedRunnerPoolImageSource.Github => "github",
                NullableActionsHostedRunnerPoolImageSource.Partner => "partner",
                NullableActionsHostedRunnerPoolImageSource.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableActionsHostedRunnerPoolImageSource? ToEnum(string value)
        {
            return value switch
            {
                "github" => NullableActionsHostedRunnerPoolImageSource.Github,
                "partner" => NullableActionsHostedRunnerPoolImageSource.Partner,
                "custom" => NullableActionsHostedRunnerPoolImageSource.Custom,
                _ => null,
            };
        }
    }
}