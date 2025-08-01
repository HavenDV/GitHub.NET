
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Default Value: not_archived
    /// </summary>
    public enum ProjectsClassicListCardsArchivedState
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        NotArchived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsClassicListCardsArchivedStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsClassicListCardsArchivedState value)
        {
            return value switch
            {
                ProjectsClassicListCardsArchivedState.All => "all",
                ProjectsClassicListCardsArchivedState.Archived => "archived",
                ProjectsClassicListCardsArchivedState.NotArchived => "not_archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsClassicListCardsArchivedState? ToEnum(string value)
        {
            return value switch
            {
                "all" => ProjectsClassicListCardsArchivedState.All,
                "archived" => ProjectsClassicListCardsArchivedState.Archived,
                "not_archived" => ProjectsClassicListCardsArchivedState.NotArchived,
                _ => null,
            };
        }
    }
}