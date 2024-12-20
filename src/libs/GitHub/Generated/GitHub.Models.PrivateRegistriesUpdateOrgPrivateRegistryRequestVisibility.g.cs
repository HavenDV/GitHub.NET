
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Which type of organization repositories have access to the private registry. `selected` means only the repositories specified by `selected_repository_ids` can access the private registry.
    /// </summary>
    public enum PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility
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
    public static class PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility value)
        {
            return value switch
            {
                PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility.All => "all",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility.Private => "private",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility.All,
                "private" => PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility.Private,
                "selected" => PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility.Selected,
                _ => null,
            };
        }
    }
}