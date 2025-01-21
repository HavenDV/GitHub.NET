
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The hosted compute service to use for the network configuration.
    /// </summary>
    public enum HostedComputeCreateNetworkConfigurationForOrgRequestComputeService
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Actions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedComputeCreateNetworkConfigurationForOrgRequestComputeServiceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedComputeCreateNetworkConfigurationForOrgRequestComputeService value)
        {
            return value switch
            {
                HostedComputeCreateNetworkConfigurationForOrgRequestComputeService.None => "none",
                HostedComputeCreateNetworkConfigurationForOrgRequestComputeService.Actions => "actions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedComputeCreateNetworkConfigurationForOrgRequestComputeService? ToEnum(string value)
        {
            return value switch
            {
                "none" => HostedComputeCreateNetworkConfigurationForOrgRequestComputeService.None,
                "actions" => HostedComputeCreateNetworkConfigurationForOrgRequestComputeService.Actions,
                _ => null,
            };
        }
    }
}