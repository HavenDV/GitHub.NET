
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Which type of organization repositories have access to the private registry. `selected` means only the repositories specified by `selected_repository_ids` can access the private registry.
    /// </summary>
    public enum PrivateRegistriesCreateOrgPrivateRegistryRequestVisibility
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
    public static class PrivateRegistriesCreateOrgPrivateRegistryRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateRegistriesCreateOrgPrivateRegistryRequestVisibility value)
        {
            return value switch
            {
                PrivateRegistriesCreateOrgPrivateRegistryRequestVisibility.All => "all",
                PrivateRegistriesCreateOrgPrivateRegistryRequestVisibility.Private => "private",
                PrivateRegistriesCreateOrgPrivateRegistryRequestVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateRegistriesCreateOrgPrivateRegistryRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => PrivateRegistriesCreateOrgPrivateRegistryRequestVisibility.All,
                "private" => PrivateRegistriesCreateOrgPrivateRegistryRequestVisibility.Private,
                "selected" => PrivateRegistriesCreateOrgPrivateRegistryRequestVisibility.Selected,
                _ => null,
            };
        }
    }
}