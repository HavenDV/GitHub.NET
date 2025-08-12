
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Default Value: open
    /// </summary>
    public enum ProjectsClassicListForOrgState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsClassicListForOrgStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsClassicListForOrgState value)
        {
            return value switch
            {
                ProjectsClassicListForOrgState.Open => "open",
                ProjectsClassicListForOrgState.Closed => "closed",
                ProjectsClassicListForOrgState.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsClassicListForOrgState? ToEnum(string value)
        {
            return value switch
            {
                "open" => ProjectsClassicListForOrgState.Open,
                "closed" => ProjectsClassicListForOrgState.Closed,
                "all" => ProjectsClassicListForOrgState.All,
                _ => null,
            };
        }
    }
}