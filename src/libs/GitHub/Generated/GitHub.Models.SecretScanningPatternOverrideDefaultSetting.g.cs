
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The default push protection setting for this pattern.
    /// </summary>
    public enum SecretScanningPatternOverrideDefaultSetting
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
    public static class SecretScanningPatternOverrideDefaultSettingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningPatternOverrideDefaultSetting value)
        {
            return value switch
            {
                SecretScanningPatternOverrideDefaultSetting.Disabled => "disabled",
                SecretScanningPatternOverrideDefaultSetting.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningPatternOverrideDefaultSetting? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => SecretScanningPatternOverrideDefaultSetting.Disabled,
                "enabled" => SecretScanningPatternOverrideDefaultSetting.Enabled,
                _ => null,
            };
        }
    }
}