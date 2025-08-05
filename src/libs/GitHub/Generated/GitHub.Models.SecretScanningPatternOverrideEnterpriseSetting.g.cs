
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The push protection setting for this pattern set at the enterprise level. Only present for partner patterns when the organization has a parent enterprise.
    /// </summary>
    public enum SecretScanningPatternOverrideEnterpriseSetting
    {
        /// <summary>
        /// 
        /// </summary>
        NotSet,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningPatternOverrideEnterpriseSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningPatternOverrideEnterpriseSetting value)
        {
            return value switch
            {
                SecretScanningPatternOverrideEnterpriseSetting.NotSet => "not-set",
                SecretScanningPatternOverrideEnterpriseSetting.Disabled => "disabled",
                SecretScanningPatternOverrideEnterpriseSetting.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningPatternOverrideEnterpriseSetting? ToEnum(string value)
        {
            return value switch
            {
                "not-set" => SecretScanningPatternOverrideEnterpriseSetting.NotSet,
                "disabled" => SecretScanningPatternOverrideEnterpriseSetting.Disabled,
                "enabled" => SecretScanningPatternOverrideEnterpriseSetting.Enabled,
                _ => null,
            };
        }
    }
}