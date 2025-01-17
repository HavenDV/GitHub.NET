
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    public enum DependabotListAlertsForRepoSort
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Updated,
        /// <summary>
        /// 
        /// </summary>
        EpssPercentage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotListAlertsForRepoSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotListAlertsForRepoSort value)
        {
            return value switch
            {
                DependabotListAlertsForRepoSort.Created => "created",
                DependabotListAlertsForRepoSort.Updated => "updated",
                DependabotListAlertsForRepoSort.EpssPercentage => "epss_percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotListAlertsForRepoSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => DependabotListAlertsForRepoSort.Created,
                "updated" => DependabotListAlertsForRepoSort.Updated,
                "epss_percentage" => DependabotListAlertsForRepoSort.EpssPercentage,
                _ => null,
            };
        }
    }
}