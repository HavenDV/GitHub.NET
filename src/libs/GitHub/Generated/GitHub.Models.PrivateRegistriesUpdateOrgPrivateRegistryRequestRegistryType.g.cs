
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
                _ => null,
            };
        }
    }
}