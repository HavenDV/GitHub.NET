
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
                _ => null,
            };
        }
    }
}