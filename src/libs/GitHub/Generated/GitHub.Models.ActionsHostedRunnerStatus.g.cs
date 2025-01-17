
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The status of the runner.<br/>
    /// Example: Ready
    /// </summary>
    public enum ActionsHostedRunnerStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Provisioning,
        /// <summary>
        /// 
        /// </summary>
        Shutdown,
        /// <summary>
        /// 
        /// </summary>
        Deleting,
        /// <summary>
        /// 
        /// </summary>
        Stuck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsHostedRunnerStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsHostedRunnerStatus value)
        {
            return value switch
            {
                ActionsHostedRunnerStatus.Ready => "Ready",
                ActionsHostedRunnerStatus.Provisioning => "Provisioning",
                ActionsHostedRunnerStatus.Shutdown => "Shutdown",
                ActionsHostedRunnerStatus.Deleting => "Deleting",
                ActionsHostedRunnerStatus.Stuck => "Stuck",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsHostedRunnerStatus? ToEnum(string value)
        {
            return value switch
            {
                "Ready" => ActionsHostedRunnerStatus.Ready,
                "Provisioning" => ActionsHostedRunnerStatus.Provisioning,
                "Shutdown" => ActionsHostedRunnerStatus.Shutdown,
                "Deleting" => ActionsHostedRunnerStatus.Deleting,
                "Stuck" => ActionsHostedRunnerStatus.Stuck,
                _ => null,
            };
        }
    }
}