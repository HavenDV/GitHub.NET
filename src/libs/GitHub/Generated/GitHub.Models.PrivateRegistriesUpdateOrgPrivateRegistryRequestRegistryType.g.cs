
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The registry type.
    /// </summary>
    public enum PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType
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
    public static class PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType value)
        {
            return value switch
            {
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.MavenRepository => "maven_repository",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.NugetFeed => "nuget_feed",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.GoproxyServer => "goproxy_server",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.NpmRegistry => "npm_registry",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.RubygemsServer => "rubygems_server",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.CargoRegistry => "cargo_registry",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.ComposerRepository => "composer_repository",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.DockerRegistry => "docker_registry",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.GitSource => "git_source",
                PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.HelmRegistry => "helm_registry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType? ToEnum(string value)
        {
            return value switch
            {
                "maven_repository" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.MavenRepository,
                "nuget_feed" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.NugetFeed,
                "goproxy_server" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.GoproxyServer,
                "npm_registry" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.NpmRegistry,
                "rubygems_server" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.RubygemsServer,
                "cargo_registry" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.CargoRegistry,
                "composer_repository" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.ComposerRepository,
                "docker_registry" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.DockerRegistry,
                "git_source" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.GitSource,
                "helm_registry" => PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType.HelmRegistry,
                _ => null,
            };
        }
    }
}