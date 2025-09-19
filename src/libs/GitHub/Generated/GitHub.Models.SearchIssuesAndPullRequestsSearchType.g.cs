
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchIssuesAndPullRequestsSearchType
    {
        /// <summary>
        /// 
        /// </summary>
        Semantic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchIssuesAndPullRequestsSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchIssuesAndPullRequestsSearchType value)
        {
            return value switch
            {
                SearchIssuesAndPullRequestsSearchType.Semantic => "semantic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchIssuesAndPullRequestsSearchType? ToEnum(string value)
        {
            return value switch
            {
                "semantic" => SearchIssuesAndPullRequestsSearchType.Semantic,
                _ => null,
            };
        }
    }
}