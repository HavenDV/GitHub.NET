
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum DependabotListAlertsForEnterpriseHasVariant2Item
    {
        /// <summary>
        /// 
        /// </summary>
        Patch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotListAlertsForEnterpriseHasVariant2ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotListAlertsForEnterpriseHasVariant2Item value)
        {
            return value switch
            {
                DependabotListAlertsForEnterpriseHasVariant2Item.Patch => "patch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotListAlertsForEnterpriseHasVariant2Item? ToEnum(string value)
        {
            return value switch
            {
                "patch" => DependabotListAlertsForEnterpriseHasVariant2Item.Patch,
                _ => null,
            };
        }
    }
}