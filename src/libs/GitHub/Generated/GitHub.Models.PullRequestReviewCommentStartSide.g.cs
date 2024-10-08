
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The side of the first line of the range for a multi-line comment.<br/>
    /// Default Value: RIGHT
    /// </summary>
    public enum PullRequestReviewCommentStartSide
    {
        /// <summary>
        /// 
        /// </summary>
        LEFT,
        /// <summary>
        /// 
        /// </summary>
        RIGHT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullRequestReviewCommentStartSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestReviewCommentStartSide value)
        {
            return value switch
            {
                PullRequestReviewCommentStartSide.LEFT => "LEFT",
                PullRequestReviewCommentStartSide.RIGHT => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestReviewCommentStartSide? ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => PullRequestReviewCommentStartSide.LEFT,
                "RIGHT" => PullRequestReviewCommentStartSide.RIGHT,
                _ => null,
            };
        }
    }
}