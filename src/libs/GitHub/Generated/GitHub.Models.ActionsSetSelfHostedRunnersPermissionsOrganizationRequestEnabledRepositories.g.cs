
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The policy that controls whether self-hosted runners can be used in the organization
    /// </summary>
    public enum ActionsSetSelfHostedRunnersPermissionsOrganizationRequestEnabledRepositories
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Selected,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsSetSelfHostedRunnersPermissionsOrganizationRequestEnabledRepositoriesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsSetSelfHostedRunnersPermissionsOrganizationRequestEnabledRepositories value)
        {
            return value switch
            {
                ActionsSetSelfHostedRunnersPermissionsOrganizationRequestEnabledRepositories.All => "all",
                ActionsSetSelfHostedRunnersPermissionsOrganizationRequestEnabledRepositories.Selected => "selected",
                ActionsSetSelfHostedRunnersPermissionsOrganizationRequestEnabledRepositories.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsSetSelfHostedRunnersPermissionsOrganizationRequestEnabledRepositories? ToEnum(string value)
        {
            return value switch
            {
                "all" => ActionsSetSelfHostedRunnersPermissionsOrganizationRequestEnabledRepositories.All,
                "selected" => ActionsSetSelfHostedRunnersPermissionsOrganizationRequestEnabledRepositories.Selected,
                "none" => ActionsSetSelfHostedRunnersPermissionsOrganizationRequestEnabledRepositories.None,
                _ => null,
            };
        }
    }
}