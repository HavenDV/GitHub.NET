
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
        /// <summary>
        /// 
        /// </summary>
        NpmRegistry,
        /// <summary>
        /// 
        /// </summary>
        RubygemsServer,
        /// <summary>
        /// 
        /// </summary>
        CargoRegistry,
        /// <summary>
        /// 
        /// </summary>
        ComposerRepository,
        /// <summary>
        /// 
        /// </summary>
        DockerRegistry,
        /// <summary>
        /// 
        /// </summary>
        GitSource,
        /// <summary>
        /// 
        /// </summary>
        HelmRegistry,
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
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.NpmRegistry => "npm_registry",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.RubygemsServer => "rubygems_server",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.CargoRegistry => "cargo_registry",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.ComposerRepository => "composer_repository",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.DockerRegistry => "docker_registry",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.GitSource => "git_source",
                OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.HelmRegistry => "helm_registry",
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
                "npm_registry" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.NpmRegistry,
                "rubygems_server" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.RubygemsServer,
                "cargo_registry" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.CargoRegistry,
                "composer_repository" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.ComposerRepository,
                "docker_registry" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.DockerRegistry,
                "git_source" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.GitSource,
                "helm_registry" => OrgPrivateRegistryConfigurationWithSelectedRepositoriesRegistryType.HelmRegistry,
                _ => null,
            };
        }
    }
}