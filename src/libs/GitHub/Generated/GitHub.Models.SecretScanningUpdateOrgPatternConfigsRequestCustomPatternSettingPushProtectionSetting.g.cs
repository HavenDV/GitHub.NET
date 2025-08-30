
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Push protection setting to set for the pattern.
    /// </summary>
    public enum SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSettingPushProtectionSetting
    {
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
    public static class SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSettingPushProtectionSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSettingPushProtectionSetting value)
        {
            return value switch
            {
                SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSettingPushProtectionSetting.Disabled => "disabled",
                SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSettingPushProtectionSetting.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSettingPushProtectionSetting? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSettingPushProtectionSetting.Disabled,
                "enabled" => SecretScanningUpdateOrgPatternConfigsRequestCustomPatternSettingPushProtectionSetting.Enabled,
                _ => null,
            };
        }
    }
}