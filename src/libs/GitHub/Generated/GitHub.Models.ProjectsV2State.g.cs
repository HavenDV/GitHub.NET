
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The current state of the project.
    /// </summary>
    public enum ProjectsV2State
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsV2StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsV2State value)
        {
            return value switch
            {
                ProjectsV2State.Open => "open",
                ProjectsV2State.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsV2State? ToEnum(string value)
        {
            return value switch
            {
                "open" => ProjectsV2State.Open,
                "closed" => ProjectsV2State.Closed,
                _ => null,
            };
        }
    }
}