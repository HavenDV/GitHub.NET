
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Which type of organization repositories have access to the private registry.
    /// </summary>
    public enum OrgPrivateRegistryConfigurationVisibility
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
    public static class OrgPrivateRegistryConfigurationVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgPrivateRegistryConfigurationVisibility value)
        {
            return value switch
            {
                OrgPrivateRegistryConfigurationVisibility.All => "all",
                OrgPrivateRegistryConfigurationVisibility.Private => "private",
                OrgPrivateRegistryConfigurationVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgPrivateRegistryConfigurationVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => OrgPrivateRegistryConfigurationVisibility.All,
                "private" => OrgPrivateRegistryConfigurationVisibility.Private,
                "selected" => OrgPrivateRegistryConfigurationVisibility.Selected,
                _ => null,
            };
        }
    }
}