
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The type of item to add to the project. Must be either Issue or PullRequest.
    /// </summary>
    public enum ProjectsAddItemForUserRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Issue,
        /// <summary>
        /// 
        /// </summary>
        PullRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsAddItemForUserRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsAddItemForUserRequestType value)
        {
            return value switch
            {
                ProjectsAddItemForUserRequestType.Issue => "Issue",
                ProjectsAddItemForUserRequestType.PullRequest => "PullRequest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsAddItemForUserRequestType? ToEnum(string value)
        {
            return value switch
            {
                "Issue" => ProjectsAddItemForUserRequestType.Issue,
                "PullRequest" => ProjectsAddItemForUserRequestType.PullRequest,
                _ => null,
            };
        }
    }
}