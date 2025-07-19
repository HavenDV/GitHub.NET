
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The registry type.
    /// </summary>
    public enum PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType
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
    public static class PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType value)
        {
            return value switch
            {
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.MavenRepository => "maven_repository",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.NugetFeed => "nuget_feed",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.GoproxyServer => "goproxy_server",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.NpmRegistry => "npm_registry",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.RubygemsServer => "rubygems_server",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.CargoRegistry => "cargo_registry",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.ComposerRepository => "composer_repository",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.DockerRegistry => "docker_registry",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.GitSource => "git_source",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.HelmRegistry => "helm_registry",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.HexOrganization => "hex_organization",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.HexRepository => "hex_repository",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.PubRepository => "pub_repository",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.PythonIndex => "python_index",
                PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.TerraformRegistry => "terraform_registry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType? ToEnum(string value)
        {
            return value switch
            {
                "maven_repository" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.MavenRepository,
                "nuget_feed" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.NugetFeed,
                "goproxy_server" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.GoproxyServer,
                "npm_registry" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.NpmRegistry,
                "rubygems_server" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.RubygemsServer,
                "cargo_registry" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.CargoRegistry,
                "composer_repository" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.ComposerRepository,
                "docker_registry" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.DockerRegistry,
                "git_source" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.GitSource,
                "helm_registry" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.HelmRegistry,
                "hex_organization" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.HexOrganization,
                "hex_repository" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.HexRepository,
                "pub_repository" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.PubRepository,
                "python_index" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.PythonIndex,
                "terraform_registry" => PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType.TerraformRegistry,
                _ => null,
            };
        }
    }
}