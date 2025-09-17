
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Retired: this field is no longer supported.<br/>
    /// Whether the enterprise team should be reflected in each organization.<br/>
    /// This value cannot be changed.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum EnterpriseTeamsUpdateRequestSyncToOrganizations
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnterpriseTeamsUpdateRequestSyncToOrganizationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnterpriseTeamsUpdateRequestSyncToOrganizations value)
        {
            return value switch
            {
                EnterpriseTeamsUpdateRequestSyncToOrganizations.All => "all",
                EnterpriseTeamsUpdateRequestSyncToOrganizations.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnterpriseTeamsUpdateRequestSyncToOrganizations? ToEnum(string value)
        {
            return value switch
            {
                "all" => EnterpriseTeamsUpdateRequestSyncToOrganizations.All,
                "disabled" => EnterpriseTeamsUpdateRequestSyncToOrganizations.Disabled,
                _ => null,
            };
        }
    }
}