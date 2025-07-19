
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
        /// <summary>
        /// 
        /// </summary>
        HexOrganization,
        /// <summary>
        /// 
        /// </summary>
        HexRepository,
        /// <summary>
        /// 
        /// </summary>
        PubRepository,
        /// <summary>
        /// 
        /// </summary>
        PythonIndex,
        /// <summary>
        /// 
        /// </summary>
        TerraformRegistry,
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
                OrgPrivateRegistryConfigurationRegistryType.NugetFeed => "nuget_feed",
                OrgPrivateRegistryConfigurationRegistryType.GoproxyServer => "goproxy_server",
                OrgPrivateRegistryConfigurationRegistryType.NpmRegistry => "npm_registry",
                OrgPrivateRegistryConfigurationRegistryType.RubygemsServer => "rubygems_server",
                OrgPrivateRegistryConfigurationRegistryType.CargoRegistry => "cargo_registry",
                OrgPrivateRegistryConfigurationRegistryType.ComposerRepository => "composer_repository",
                OrgPrivateRegistryConfigurationRegistryType.DockerRegistry => "docker_registry",
                OrgPrivateRegistryConfigurationRegistryType.GitSource => "git_source",
                OrgPrivateRegistryConfigurationRegistryType.HelmRegistry => "helm_registry",
                OrgPrivateRegistryConfigurationRegistryType.HexOrganization => "hex_organization",
                OrgPrivateRegistryConfigurationRegistryType.HexRepository => "hex_repository",
                OrgPrivateRegistryConfigurationRegistryType.PubRepository => "pub_repository",
                OrgPrivateRegistryConfigurationRegistryType.PythonIndex => "python_index",
                OrgPrivateRegistryConfigurationRegistryType.TerraformRegistry => "terraform_registry",
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
                "nuget_feed" => OrgPrivateRegistryConfigurationRegistryType.NugetFeed,
                "goproxy_server" => OrgPrivateRegistryConfigurationRegistryType.GoproxyServer,
                "npm_registry" => OrgPrivateRegistryConfigurationRegistryType.NpmRegistry,
                "rubygems_server" => OrgPrivateRegistryConfigurationRegistryType.RubygemsServer,
                "cargo_registry" => OrgPrivateRegistryConfigurationRegistryType.CargoRegistry,
                "composer_repository" => OrgPrivateRegistryConfigurationRegistryType.ComposerRepository,
                "docker_registry" => OrgPrivateRegistryConfigurationRegistryType.DockerRegistry,
                "git_source" => OrgPrivateRegistryConfigurationRegistryType.GitSource,
                "helm_registry" => OrgPrivateRegistryConfigurationRegistryType.HelmRegistry,
                "hex_organization" => OrgPrivateRegistryConfigurationRegistryType.HexOrganization,
                "hex_repository" => OrgPrivateRegistryConfigurationRegistryType.HexRepository,
                "pub_repository" => OrgPrivateRegistryConfigurationRegistryType.PubRepository,
                "python_index" => OrgPrivateRegistryConfigurationRegistryType.PythonIndex,
                "terraform_registry" => OrgPrivateRegistryConfigurationRegistryType.TerraformRegistry,
                _ => null,
            };
        }
    }
}