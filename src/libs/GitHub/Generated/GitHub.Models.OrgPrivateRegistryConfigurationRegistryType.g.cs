
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The registry type.
    /// </summary>
    public enum OrgPrivateRegistryConfigurationRegistryType
    {
        /// <summary>
        /// 
        /// </summary>
        MavenRepository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgPrivateRegistryConfigurationRegistryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgPrivateRegistryConfigurationRegistryType value)
        {
            return value switch
            {
                OrgPrivateRegistryConfigurationRegistryType.MavenRepository => "maven_repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgPrivateRegistryConfigurationRegistryType? ToEnum(string value)
        {
            return value switch
            {
                "maven_repository" => OrgPrivateRegistryConfigurationRegistryType.MavenRepository,
                _ => null,
            };
        }
    }
}