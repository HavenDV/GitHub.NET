
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Push protection setting to set for the pattern.
    /// </summary>
    public enum SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting
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
    public static class SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting value)
        {
            return value switch
            {
                SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting.NotSet => "not-set",
                SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting.Disabled => "disabled",
                SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting? ToEnum(string value)
        {
            return value switch
            {
                "not-set" => SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting.NotSet,
                "disabled" => SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting.Disabled,
                "enabled" => SecretScanningUpdateOrgPatternConfigsRequestProviderPatternSettingPushProtectionSetting.Enabled,
                _ => null,
            };
        }
    }
}