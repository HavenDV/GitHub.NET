
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Default Value: open
    /// </summary>
    public enum ProjectsClassicListForRepoState
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
    public static class ProjectsClassicListForRepoStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsClassicListForRepoState value)
        {
            return value switch
            {
                ProjectsClassicListForRepoState.Open => "open",
                ProjectsClassicListForRepoState.Closed => "closed",
                ProjectsClassicListForRepoState.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsClassicListForRepoState? ToEnum(string value)
        {
            return value switch
            {
                "open" => ProjectsClassicListForRepoState.Open,
                "closed" => ProjectsClassicListForRepoState.Closed,
                "all" => ProjectsClassicListForRepoState.All,
                _ => null,
            };
        }
    }
}