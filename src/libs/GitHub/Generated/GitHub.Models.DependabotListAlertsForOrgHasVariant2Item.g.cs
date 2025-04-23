
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum DependabotListAlertsForOrgHasVariant2Item
    {
        /// <summary>
        /// 
        /// </summary>
        Patch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotListAlertsForOrgHasVariant2ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotListAlertsForOrgHasVariant2Item value)
        {
            return value switch
            {
                DependabotListAlertsForOrgHasVariant2Item.Patch => "patch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotListAlertsForOrgHasVariant2Item? ToEnum(string value)
        {
            return value switch
            {
                "patch" => DependabotListAlertsForOrgHasVariant2Item.Patch,
                _ => null,
            };
        }
    }
}