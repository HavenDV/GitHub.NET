
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Default Value: open
    /// </summary>
    public enum ProjectsClassicListForUserState
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
    public static class ProjectsClassicListForUserStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsClassicListForUserState value)
        {
            return value switch
            {
                ProjectsClassicListForUserState.Open => "open",
                ProjectsClassicListForUserState.Closed => "closed",
                ProjectsClassicListForUserState.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsClassicListForUserState? ToEnum(string value)
        {
            return value switch
            {
                "open" => ProjectsClassicListForUserState.Open,
                "closed" => ProjectsClassicListForUserState.Closed,
                "all" => ProjectsClassicListForUserState.All,
                _ => null,
            };
        }
    }
}