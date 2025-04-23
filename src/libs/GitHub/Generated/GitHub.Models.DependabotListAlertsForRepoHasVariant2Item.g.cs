
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum DependabotListAlertsForRepoHasVariant2Item
    {
        /// <summary>
        /// 
        /// </summary>
        Patch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotListAlertsForRepoHasVariant2ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotListAlertsForRepoHasVariant2Item value)
        {
            return value switch
            {
                DependabotListAlertsForRepoHasVariant2Item.Patch => "patch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotListAlertsForRepoHasVariant2Item? ToEnum(string value)
        {
            return value switch
            {
                "patch" => DependabotListAlertsForRepoHasVariant2Item.Patch,
                _ => null,
            };
        }
    }
}