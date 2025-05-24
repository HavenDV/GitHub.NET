
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The registry type.
    /// </summary>
    public enum OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType
    {
        /// <summary>
        /// 
        /// </summary>
        MavenRepository,
        /// <summary>
        /// 
        /// </summary>
        NugetFeed,
        /// <summary>
        /// 
        /// </summary>
        GoproxyServer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType value)
        {
            return value switch
            {
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.MavenRepository => "maven_repository",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.NugetFeed => "nuget_feed",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.GoproxyServer => "goproxy_server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType? ToEnum(string value)
        {
            return value switch
            {
                "maven_repository" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.MavenRepository,
                "nuget_feed" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.NugetFeed,
                "goproxy_server" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.GoproxyServer,
                _ => null,
            };
        }
    }
}