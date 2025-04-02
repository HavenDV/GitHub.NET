
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecurityAndAnalysisCodeSecurityStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecurityAndAnalysisCodeSecurityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAndAnalysisCodeSecurityStatus value)
        {
            return value switch
            {
                SecurityAndAnalysisCodeSecurityStatus.Enabled => "enabled",
                SecurityAndAnalysisCodeSecurityStatus.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAndAnalysisCodeSecurityStatus? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => SecurityAndAnalysisCodeSecurityStatus.Enabled,
                "disabled" => SecurityAndAnalysisCodeSecurityStatus.Disabled,
                _ => null,
            };
        }
    }
}