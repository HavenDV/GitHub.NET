
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Which type of organization repositories have access to the private registry. `selected` means only the repositories specified by `selected_repository_ids` can access the private registry.
    /// </summary>
    public enum OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility value)
        {
            return value switch
            {
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility.All => "all",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility.Private => "private",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility.All,
                "private" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility.Private,
                "selected" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility.Selected,
                _ => null,
            };
        }
    }
}