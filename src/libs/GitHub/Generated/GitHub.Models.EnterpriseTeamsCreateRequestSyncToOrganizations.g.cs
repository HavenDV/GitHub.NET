
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Retired: this field is no longer supported.<br/>
    /// Whether the enterprise team should be reflected in each organization.<br/>
    /// This value cannot be set.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum EnterpriseTeamsCreateRequestSyncToOrganizations
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
    public static class EnterpriseTeamsCreateRequestSyncToOrganizationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnterpriseTeamsCreateRequestSyncToOrganizations value)
        {
            return value switch
            {
                EnterpriseTeamsCreateRequestSyncToOrganizations.All => "all",
                EnterpriseTeamsCreateRequestSyncToOrganizations.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnterpriseTeamsCreateRequestSyncToOrganizations? ToEnum(string value)
        {
            return value switch
            {
                "all" => EnterpriseTeamsCreateRequestSyncToOrganizations.All,
                "disabled" => EnterpriseTeamsCreateRequestSyncToOrganizations.Disabled,
                _ => null,
            };
        }
    }
}