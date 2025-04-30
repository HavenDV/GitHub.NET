
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum OrgsListOutsideCollaboratorsFilter
    {
        /// <summary>
        /// //github.com/blog/1614-two-factor-authentication) enabled will be returned. `2fa_insecure` means that only outside collaborators with [insecure 2FA methods](https://docs.github.com/organizations/keeping-your-organization-secure/managing-two-factor-authentication-for-your-organization/requiring-two-factor-authentication-in-your-organization#requiring-secure-methods-of-two-factor-authentication-in-your-organization) will be returned.
        /// </summary>
        x2faDisabled,
        /// <summary>
        /// //github.com/blog/1614-two-factor-authentication) enabled will be returned. `2fa_insecure` means that only outside collaborators with [insecure 2FA methods](https://docs.github.com/organizations/keeping-your-organization-secure/managing-two-factor-authentication-for-your-organization/requiring-two-factor-authentication-in-your-organization#requiring-secure-methods-of-two-factor-authentication-in-your-organization) will be returned.
        /// </summary>
        x2faInsecure,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsListOutsideCollaboratorsFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsListOutsideCollaboratorsFilter value)
        {
            return value switch
            {
                OrgsListOutsideCollaboratorsFilter.x2faDisabled => "2fa_disabled",
                OrgsListOutsideCollaboratorsFilter.x2faInsecure => "2fa_insecure",
                OrgsListOutsideCollaboratorsFilter.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsListOutsideCollaboratorsFilter? ToEnum(string value)
        {
            return value switch
            {
                "2fa_disabled" => OrgsListOutsideCollaboratorsFilter.x2faDisabled,
                "2fa_insecure" => OrgsListOutsideCollaboratorsFilter.x2faInsecure,
                "all" => OrgsListOutsideCollaboratorsFilter.All,
                _ => null,
            };
        }
    }
}