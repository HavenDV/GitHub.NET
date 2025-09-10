
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The type of item to add to the project. Must be either Issue or PullRequest.
    /// </summary>
    public enum ProjectsAddItemForOrgRequestType
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
    public static class ProjectsAddItemForOrgRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsAddItemForOrgRequestType value)
        {
            return value switch
            {
                ProjectsAddItemForOrgRequestType.Issue => "Issue",
                ProjectsAddItemForOrgRequestType.PullRequest => "PullRequest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsAddItemForOrgRequestType? ToEnum(string value)
        {
            return value switch
            {
                "Issue" => ProjectsAddItemForOrgRequestType.Issue,
                "PullRequest" => ProjectsAddItemForOrgRequestType.PullRequest,
                _ => null,
            };
        }
    }
}