
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Required when using `merge_commit_message`.<br/>
    /// The default value for a merge commit title.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull request #123 from branch-name).
    /// </summary>
    public enum ReposCreateForAuthenticatedUserRequestMergeCommitTitle
    {
        /// <summary>
        /// 
        /// </summary>
        PRTITLE,
        /// <summary>
        /// 
        /// </summary>
        MERGEMESSAGE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposCreateForAuthenticatedUserRequestMergeCommitTitleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateForAuthenticatedUserRequestMergeCommitTitle value)
        {
            return value switch
            {
                ReposCreateForAuthenticatedUserRequestMergeCommitTitle.PRTITLE => "PR_TITLE",
                ReposCreateForAuthenticatedUserRequestMergeCommitTitle.MERGEMESSAGE => "MERGE_MESSAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateForAuthenticatedUserRequestMergeCommitTitle? ToEnum(string value)
        {
            return value switch
            {
                "PR_TITLE" => ReposCreateForAuthenticatedUserRequestMergeCommitTitle.PRTITLE,
                "MERGE_MESSAGE" => ReposCreateForAuthenticatedUserRequestMergeCommitTitle.MERGEMESSAGE,
                _ => null,
            };
        }
    }
}